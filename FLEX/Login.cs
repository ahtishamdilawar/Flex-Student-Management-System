//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Login : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Login(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Login obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Login obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~Login() {
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
          FLEXPINVOKE.delete_Login(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Login(string arg0, string arg1) : this(FLEXPINVOKE.new_Login__SWIG_0(arg0, arg1), true) {
    if (FLEXPINVOKE.SWIGPendingException.Pending) throw FLEXPINVOKE.SWIGPendingException.Retrieve();
  }

  public Login(string arg0) : this(FLEXPINVOKE.new_Login__SWIG_1(arg0), true) {
    if (FLEXPINVOKE.SWIGPendingException.Pending) throw FLEXPINVOKE.SWIGPendingException.Retrieve();
  }

  public Login() : this(FLEXPINVOKE.new_Login__SWIG_2(), true) {
  }

  public void setUserName(string arg0) {
    FLEXPINVOKE.Login_setUserName(swigCPtr, arg0);
    if (FLEXPINVOKE.SWIGPendingException.Pending) throw FLEXPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPassword(string arg0) {
    FLEXPINVOKE.Login_setPassword(swigCPtr, arg0);
    if (FLEXPINVOKE.SWIGPendingException.Pending) throw FLEXPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getUserName() {
    string ret = FLEXPINVOKE.Login_getUserName(swigCPtr);
    return ret;
  }

  public string getPassword() {
    string ret = FLEXPINVOKE.Login_getPassword(swigCPtr);
    return ret;
  }

}
