//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace uplink.SWIG {

public class UplinkConfig_Volatile_tls : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UplinkConfig_Volatile_tls(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UplinkConfig_Volatile_tls obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UplinkConfig_Volatile_tls() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          storj_uplinkPINVOKE.delete_UplinkConfig_Volatile_tls(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool skip_peer_ca_whitelist {
    set {
      storj_uplinkPINVOKE.UplinkConfig_Volatile_tls_skip_peer_ca_whitelist_set(swigCPtr, value);
    } 
    get {
      bool ret = storj_uplinkPINVOKE.UplinkConfig_Volatile_tls_skip_peer_ca_whitelist_get(swigCPtr);
      return ret;
    } 
  }

  public UplinkConfig_Volatile_tls() : this(storj_uplinkPINVOKE.new_UplinkConfig_Volatile_tls(), true) {
  }

}

}