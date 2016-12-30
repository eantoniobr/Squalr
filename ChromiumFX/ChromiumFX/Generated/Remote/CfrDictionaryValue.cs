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

    /// <summary>
    /// Structure representing a dictionary value. Can be used on any process and
    /// thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
    /// </remarks>
    public class CfrDictionaryValue : CfrLibraryBase {

        internal static CfrDictionaryValue Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrDictionaryValue)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrDictionaryValue(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Creates a new object that is not owned by any other object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public static CfrDictionaryValue Create() {
            var call = new CfxDictionaryValueCreateRemoteCall();
            call.RequestExecution();
            return CfrDictionaryValue.Wrap(new RemotePtr(call.__retval));
        }


        private CfrDictionaryValue(RemotePtr remotePtr) : base(remotePtr) {}

        /// <summary>
        /// Returns true (1) if this object is valid. This object may become invalid if
        /// the underlying data is owned by another object (e.g. list or dictionary)
        /// and that other object is then modified or destroyed. Do not call any other
        /// functions if this function returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                var call = new CfxDictionaryValueIsValidRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this object is currently owned by another object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsOwned {
            get {
                var call = new CfxDictionaryValueIsOwnedRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                var call = new CfxDictionaryValueIsReadOnlyRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns the number of values.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public ulong Size {
            get {
                var call = new CfxDictionaryValueGetSizeRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if this object and |that| object have the same underlying
        /// data. If true (1) modifications to this object will also affect |that|
        /// object and vice-versa.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsSame(CfrDictionaryValue that) {
            var call = new CfxDictionaryValueIsSameRemoteCall();
            call.@this = RemotePtr.ptr;
            call.that = CfrObject.Unwrap(that).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if this object and |that| object have an equivalent
        /// underlying value but are not necessarily the same object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool IsEqual(CfrDictionaryValue that) {
            var call = new CfxDictionaryValueIsEqualRemoteCall();
            call.@this = RemotePtr.ptr;
            call.that = CfrObject.Unwrap(that).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns a writable copy of this object. If |excludeNullChildren| is true
        /// (1) any NULL dictionaries or lists will be excluded from the copy.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfrDictionaryValue Copy(bool excludeEmptyChildren) {
            var call = new CfxDictionaryValueCopyRemoteCall();
            call.@this = RemotePtr.ptr;
            call.excludeEmptyChildren = excludeEmptyChildren;
            call.RequestExecution(RemotePtr.connection);
            return CfrDictionaryValue.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Removes all values. Returns true (1) on success.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool Clear() {
            var call = new CfxDictionaryValueClearRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the current dictionary has a value for the given key.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool HasKey(string key) {
            var call = new CfxDictionaryValueHasKeyRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool GetKeys(System.Collections.Generic.List<string> keys) {
            var call = new CfxDictionaryValueGetKeysRemoteCall();
            call.@this = RemotePtr.ptr;
            call.keys = keys;
            call.RequestExecution(RemotePtr.connection);
            StringFunctions.CopyCfxStringList(call.keys, keys);
            return call.__retval;
        }

        /// <summary>
        /// Removes the value at the specified key. Returns true (1) is the value was
        /// removed successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool Remove(string key) {
            var call = new CfxDictionaryValueRemoveRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value type for the specified key.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfxValueType GetType(string key) {
            var call = new CfxDictionaryValueGetTypeRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return (CfxValueType)call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key. For simple types the returned value
        /// will copy existing data and modifications to the value will not modify this
        /// object. For complex types (binary, dictionary and list) the returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfrValue GetValue(string key) {
            var call = new CfxDictionaryValueGetValueRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return CfrValue.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool GetBool(string key) {
            var call = new CfxDictionaryValueGetBoolRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type int.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public int GetInt(string key) {
            var call = new CfxDictionaryValueGetIntRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type double.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public double GetDouble(string key) {
            var call = new CfxDictionaryValueGetDoubleRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public string GetString(string key) {
            var call = new CfxDictionaryValueGetStringRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value at the specified key as type binary. The returned value
        /// will reference existing data.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfrBinaryValue GetBinary(string key) {
            var call = new CfxDictionaryValueGetBinaryRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return CfrBinaryValue.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Returns the value at the specified key as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfrDictionaryValue GetDictionary(string key) {
            var call = new CfxDictionaryValueGetDictionaryRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return CfrDictionaryValue.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Returns the value at the specified key as type list. The returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public CfrListValue GetList(string key) {
            var call = new CfxDictionaryValueGetListRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return CfrListValue.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Sets the value at the specified key. Returns true (1) if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetValue(string key, CfrValue value) {
            var call = new CfxDictionaryValueSetValueRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = CfrObject.Unwrap(value).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type null. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetNull(string key) {
            var call = new CfxDictionaryValueSetNullRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetBool(string key, bool value) {
            var call = new CfxDictionaryValueSetBoolRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = value;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type int. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetInt(string key, int value) {
            var call = new CfxDictionaryValueSetIntRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = value;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type double. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetDouble(string key, double value) {
            var call = new CfxDictionaryValueSetDoubleRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = value;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type string. Returns true (1) if the
        /// value was set successfully.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetString(string key, string value) {
            var call = new CfxDictionaryValueSetStringRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = value;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type binary. Returns true (1) if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetBinary(string key, CfrBinaryValue value) {
            var call = new CfxDictionaryValueSetBinaryRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = CfrObject.Unwrap(value).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type dict. Returns true (1) if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetDictionary(string key, CfrDictionaryValue value) {
            var call = new CfxDictionaryValueSetDictionaryRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = CfrObject.Unwrap(value).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Sets the value at the specified key as type list. Returns true (1) if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_values_capi.h">cef/include/capi/cef_values_capi.h</see>.
        /// </remarks>
        public bool SetList(string key, CfrListValue value) {
            var call = new CfxDictionaryValueSetListRemoteCall();
            call.@this = RemotePtr.ptr;
            call.key = key;
            call.value = CfrObject.Unwrap(value).ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }
    }
}