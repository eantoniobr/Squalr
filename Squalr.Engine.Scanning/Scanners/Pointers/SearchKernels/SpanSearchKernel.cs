﻿namespace Squalr.Engine.Scanning.Scanners.Pointers.SearchKernels
{
    using Squalr.Engine.OS;
    using Squalr.Engine.Scanning.Snapshots;
    using Squalr.Engine.Utils.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    internal class SpanSearchKernel : ISearchKernel
    {
        public SpanSearchKernel(Snapshot boundsSnapshot, UInt32 radius)
        {
            this.BoundsSnapshot = boundsSnapshot;
            this.Radius = radius;

            this.LowerBounds = this.GetLowerBounds();
            this.UpperBounds = this.GetUpperBounds();

            this.LArray = new UInt32[Vectors.VectorSize / sizeof(UInt32)];
            this.UArray = new UInt32[Vectors.VectorSize / sizeof(UInt32)];

            this.Comparer = Comparer<UInt32>.Create((x, y) => 0);
        }

        private Snapshot BoundsSnapshot { get; set; }

        private UInt32 Radius { get; set; }

        private UInt32[] LowerBounds { get; set; }

        private UInt32[] UpperBounds { get; set; }

        private UInt32[] LArray { get; set; }

        private UInt32[] UArray { get; set; }

        private Comparer<UInt32> Comparer;

        public Func<Vector<Byte>> GetSearchKernel(SnapshotElementVectorComparer snapshotElementVectorComparer)
        {
            return new Func<Vector<Byte>>(() =>
            {
                Span<UInt32> lowerBounds = this.LowerBounds;
                Span<UInt32> upperBounds = this.UpperBounds;
                Vector<UInt32> currentValues = Vector.AsVectorUInt32(snapshotElementVectorComparer.CurrentValues);

                for (Int32 index = 0; index < Vectors.VectorSize / sizeof(UInt32); index++)
                {
                    Int32 targetIndex = lowerBounds.BinarySearch(currentValues[index], this.Comparer);
                    this.LArray[index] = this.LowerBounds[targetIndex];
                    this.UArray[index] = this.UpperBounds[targetIndex];
                }

                return Vector.AsVectorByte(Vector.BitwiseAnd(Vector.GreaterThanOrEqual(currentValues, new Vector<UInt32>(this.LArray)), Vector.LessThanOrEqual(currentValues, new Vector<UInt32>(this.UArray))));
            });
        }

        public UInt32[] GetLowerBounds()
        {
            IEnumerable<UInt32> lowerBounds = this.BoundsSnapshot.SnapshotRegions.Select(region => unchecked((UInt32)region.BaseAddress.Subtract(this.Radius, wrapAround: false)));


            return lowerBounds.ToArray();
        }

        public UInt32[] GetUpperBounds()
        {
            IEnumerable<UInt32> upperBounds = this.BoundsSnapshot.SnapshotRegions.Select(region => unchecked((UInt32)region.EndAddress.Add(this.Radius, wrapAround: false)));

            return upperBounds.ToArray();
        }
    }
    //// End class
}
//// End namespace