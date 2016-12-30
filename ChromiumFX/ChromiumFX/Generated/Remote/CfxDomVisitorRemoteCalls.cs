// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {
    using Event;

    internal class CfxDomVisitorCtorWithGCHandleRemoteCall : CtorWithGCHandleRemoteCall {

        internal CfxDomVisitorCtorWithGCHandleRemoteCall()
            : base(RemoteCallId.CfxDomVisitorCtorWithGCHandleRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            __retval = CfxApi.DomVisitor.cfx_domvisitor_ctor(gcHandlePtr, 1);
        }
    }

    internal class CfxDomVisitorSetCallbackRemoteCall : SetCallbackRemoteCall {

        internal CfxDomVisitorSetCallbackRemoteCall()
            : base(RemoteCallId.CfxDomVisitorSetCallbackRemoteCall) {}

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            CfxDomVisitorRemoteClient.SetCallback(self, index, active);
        }
    }

    internal class CfxDomVisitorVisitRemoteEventCall : RemoteEventCall {

        internal CfxDomVisitorVisitRemoteEventCall()
            : base(RemoteCallId.CfxDomVisitorVisitRemoteEventCall) {}

        internal IntPtr document;
        internal int document_release;

        protected override void WriteArgs(StreamHandler h) {
            h.Write(gcHandlePtr);
            h.Write(document);
        }

        protected override void ReadArgs(StreamHandler h) {
            h.Read(out gcHandlePtr);
            h.Read(out document);
        }

        protected override void WriteReturn(StreamHandler h) {
            h.Write(document_release);
        }

        protected override void ReadReturn(StreamHandler h) {
            h.Read(out document_release);
        }

        protected override void ExecuteInTargetProcess(RemoteConnection connection) {
            var self = (CfrDomVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfrDomVisitorVisitEventArgs(this);
            self.m_Visit?.Invoke(self, e);
            e.m_isInvalid = true;
            document_release = e.m_document_wrapped == null? 1 : 0;
        }
    }

}