// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsICacheEntryDescriptor.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    ///-*- Mode: IDL; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("90b17d31-46aa-4fb1-a206-473c966cbc18")]
	public interface nsICacheEntryDescriptor : nsICacheEntryInfo
	{
		
		/// <summary>
        /// Get the client id associated with this cache entry.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetClientIDAttribute();
		
		/// <summary>
        /// Get the id for the device that stores this cache entry.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetDeviceIDAttribute();
		
		/// <summary>
        /// Get the key identifying the cache entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);
		
		/// <summary>
        /// Get the number of times the cache entry has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetFetchCountAttribute();
		
		/// <summary>
        /// Get the last time the cache entry was opened (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLastFetchedAttribute();
		
		/// <summary>
        /// Get the last time the cache entry was modified (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLastModifiedAttribute();
		
		/// <summary>
        /// Get the expiration time of the cache entry (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetExpirationTimeAttribute();
		
		/// <summary>
        /// Get the cache entry data size.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetDataSizeAttribute();
		
		/// <summary>
        /// Find out whether or not the cache entry is stream based.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsStreamBased();
		
		/// <summary>
        /// Set the time at which the cache entry should be considered invalid (in
        /// seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetExpirationTime(uint expirationTime);
		
		/// <summary>
        /// Set the cache entry data size.  This will fail if the cache entry
        /// IS stream based.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataSize(uint size);
		
		/// <summary>
        /// Open blocking input stream to cache data.  This will fail if the cache
        /// entry IS NOT stream based.  Use the stream transport service to
        /// asynchronously read this stream on a background thread.  The returned
        /// stream MAY implement nsISeekableStream.
        ///
        /// @param offset
        /// read starting from this offset into the cached data.  an offset
        /// beyond the end of the stream has undefined consequences.
        ///
        /// @return blocking, unbuffered input stream.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream OpenInputStream(uint offset);
		
		/// <summary>
        /// Open blocking output stream to cache data.  This will fail if the cache
        /// entry IS NOT stream based.  Use the stream transport service to
        /// asynchronously write to this stream on a background thread.  The returned
        /// stream MAY implement nsISeekableStream.
        ///
        /// If opening an output stream to existing cached data, the data will be
        /// truncated to the specified offset.
        ///
        /// @param offset
        /// write starting from this offset into the cached data.  an offset
        /// beyond the end of the stream has undefined consequences.
        ///
        /// @return blocking, unbuffered output stream.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIOutputStream OpenOutputStream(uint offset);
		
		/// <summary>
        /// Get/set the cache data element.  This will fail if the cache entry
        /// IS stream based.  The cache entry holds a strong reference to this
        /// object.  The object will be released when the cache entry is destroyed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetCacheElementAttribute();
		
		/// <summary>
        /// Get/set the cache data element.  This will fail if the cache entry
        /// IS stream based.  The cache entry holds a strong reference to this
        /// object.  The object will be released when the cache entry is destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheElementAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aCacheElement);
		
		/// <summary>
        /// Stores the Content-Length specified in the HTTP header for this
        /// entry. Checked before we write to the cache entry, to prevent ever
        /// taking up space in the cache for an entry that we know up front
        /// is going to have to be evicted anyway. See bug 588507.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPredictedDataSizeAttribute();
		
		/// <summary>
        /// Stores the Content-Length specified in the HTTP header for this
        /// entry. Checked before we write to the cache entry, to prevent ever
        /// taking up space in the cache for an entry that we know up front
        /// is going to have to be evicted anyway. See bug 588507.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPredictedDataSizeAttribute(long aPredictedDataSize);
		
		/// <summary>
        /// Get the access granted to this descriptor.  See nsICache.idl for the
        /// definitions of the access modes and a thorough description of their
        /// corresponding meanings.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetAccessGrantedAttribute();
		
		/// <summary>
        /// Get/set the storage policy of the cache entry.  See nsICache.idl for
        /// the definitions of the storage policies.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetStoragePolicyAttribute();
		
		/// <summary>
        /// Get/set the storage policy of the cache entry.  See nsICache.idl for
        /// the definitions of the storage policies.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStoragePolicyAttribute(System.IntPtr aStoragePolicy);
		
		/// <summary>
        /// Get the disk file associated with the cache entry.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFileAttribute();
		
		/// <summary>
        /// Get/set security info on the cache entry for this descriptor.  This fails
        /// if the storage policy is not STORE_IN_MEMORY.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// Get/set security info on the cache entry for this descriptor.  This fails
        /// if the storage policy is not STORE_IN_MEMORY.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aSecurityInfo);
		
		/// <summary>
        /// Get the size of the cache entry data, as stored. This may differ
        /// from the entry's dataSize, if the entry is compressed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStorageDataSizeAttribute();
		
		/// <summary>
        /// Doom the cache entry this descriptor references in order to slate it for
        /// removal.  Once doomed a cache entry cannot be undoomed.
        ///
        /// A descriptor with WRITE access can doom the cache entry and choose to
        /// fail pending requests.  This means that pending requests will not get
        /// a cache descriptor.  This is meant as a tool for clients that wish to
        /// instruct pending requests to skip the cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Doom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoomAndFailPendingRequests(int status);
		
		/// <summary>
        /// Asynchronously doom an entry. Listener will be notified about the status
        /// of the operation. Null may be passed if caller doesn't care about the
        /// result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncDoom([MarshalAs(UnmanagedType.Interface)] nsICacheListener listener);
		
		/// <summary>
        /// A writer must validate this cache object before any readers are given
        /// a descriptor to the object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkValid();
		
		/// <summary>
        /// Explicitly close the descriptor (optional).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Methods for accessing meta data.  Meta data is a table of key/value
        /// string pairs.  The strings do not have to conform to any particular
        /// charset, but they must be null terminated.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);
		
		/// <summary>
        /// Visitor will be called with key/value pair for each meta data element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitMetaData([MarshalAs(UnmanagedType.Interface)] nsICacheMetaDataVisitor visitor);
	}
	
	/// <summary>nsICacheMetaDataVisitor </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("22f9a49c-3cf8-4c23-8006-54efb11ac562")]
	public interface nsICacheMetaDataVisitor
	{
		
		/// <summary>
        /// Called for each key/value pair in the meta data for a cache entry
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool VisitMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);
	}
}