//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


class FLEXPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="SWIGRegisterExceptionCallbacks_FLEX")]
    public static extern void SWIGRegisterExceptionCallbacks_FLEX(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_FLEX")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_FLEX(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_FLEX(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_FLEX(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;
    private static global::System.Object exceptionsLock = null;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(exceptionsLock) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(exceptionsLock) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }

    static SWIGPendingException() {
      exceptionsLock = new global::System.Object();
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="SWIGRegisterStringCallback_FLEX")]
    public static extern void SWIGRegisterStringCallback_FLEX(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_FLEX(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static FLEXPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Login__SWIG_0")]
  public static extern global::System.IntPtr new_Login__SWIG_0(string jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Login__SWIG_1")]
  public static extern global::System.IntPtr new_Login__SWIG_1(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Login__SWIG_2")]
  public static extern global::System.IntPtr new_Login__SWIG_2();

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Login_setUserName")]
  public static extern void Login_setUserName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Login_setPassword")]
  public static extern void Login_setPassword(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Login_getUserName")]
  public static extern string Login_getUserName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Login_getPassword")]
  public static extern string Login_getPassword(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_delete_Login")]
  public static extern void delete_Login(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_delete_Person")]
  public static extern void delete_Person(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setFirstName")]
  public static extern void Person_setFirstName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setLastName")]
  public static extern void Person_setLastName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setDepName")]
  public static extern void Person_setDepName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setGender")]
  public static extern void Person_setGender(global::System.Runtime.InteropServices.HandleRef jarg1, char jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setContactNo")]
  public static extern void Person_setContactNo(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setAddress")]
  public static extern void Person_setAddress(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setQualification")]
  public static extern void Person_setQualification(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getGender")]
  public static extern char Person_getGender(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getFirstName")]
  public static extern string Person_getFirstName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getLastName")]
  public static extern string Person_getLastName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getDepName")]
  public static extern string Person_getDepName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getContactNo")]
  public static extern string Person_getContactNo(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getAddress")]
  public static extern string Person_getAddress(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getQualification")]
  public static extern string Person_getQualification(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_getRegDate")]
  public static extern string Person_getRegDate(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_setRegDate")]
  public static extern void Person_setRegDate(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Attendance_getDate")]
  public static extern string Attendance_getDate(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Attendance_setDate")]
  public static extern void Attendance_setDate(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Attendance_getStatus")]
  public static extern string Attendance_getStatus(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Attendance_setStatus")]
  public static extern void Attendance_setStatus(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Attendance")]
  public static extern global::System.IntPtr new_Attendance();

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_delete_Attendance")]
  public static extern void delete_Attendance(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_attendance_set")]
  public static extern void Student_attendance_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_attendance_get")]
  public static extern global::System.IntPtr Student_attendance_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_0")]
  public static extern global::System.IntPtr new_Student__SWIG_0(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10, string jarg11, string jarg12, bool jarg13, string jarg14, string jarg15);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_1")]
  public static extern global::System.IntPtr new_Student__SWIG_1(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10, string jarg11, string jarg12, bool jarg13, string jarg14);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_2")]
  public static extern global::System.IntPtr new_Student__SWIG_2(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10, string jarg11, string jarg12, bool jarg13);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_3")]
  public static extern global::System.IntPtr new_Student__SWIG_3(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10, string jarg11, string jarg12);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_4")]
  public static extern global::System.IntPtr new_Student__SWIG_4(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10, string jarg11);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_5")]
  public static extern global::System.IntPtr new_Student__SWIG_5(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_6")]
  public static extern global::System.IntPtr new_Student__SWIG_6(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_7")]
  public static extern global::System.IntPtr new_Student__SWIG_7(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_8")]
  public static extern global::System.IntPtr new_Student__SWIG_8(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_9")]
  public static extern global::System.IntPtr new_Student__SWIG_9(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_10")]
  public static extern global::System.IntPtr new_Student__SWIG_10(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_11")]
  public static extern global::System.IntPtr new_Student__SWIG_11(string jarg1, string jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_12")]
  public static extern global::System.IntPtr new_Student__SWIG_12(string jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_13")]
  public static extern global::System.IntPtr new_Student__SWIG_13(string jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_14")]
  public static extern global::System.IntPtr new_Student__SWIG_14(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Student__SWIG_15")]
  public static extern global::System.IntPtr new_Student__SWIG_15();

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_setBloodGroup")]
  public static extern void Student_setBloodGroup(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_getBloodGroup")]
  public static extern string Student_getBloodGroup(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_setRollNo")]
  public static extern void Student_setRollNo(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_getRollNo")]
  public static extern string Student_getRollNo(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_setMarks")]
  public static extern void Student_setMarks(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_getMarks")]
  public static extern string Student_getMarks(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_setFeeStatus")]
  public static extern void Student_setFeeStatus(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_getFeeStatus")]
  public static extern string Student_getFeeStatus(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_delete_Student")]
  public static extern void delete_Student(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_0")]
  public static extern global::System.IntPtr new_Teacher__SWIG_0(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9, string jarg10);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_1")]
  public static extern global::System.IntPtr new_Teacher__SWIG_1(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8, string jarg9);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_2")]
  public static extern global::System.IntPtr new_Teacher__SWIG_2(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7, string jarg8);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_3")]
  public static extern global::System.IntPtr new_Teacher__SWIG_3(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6, string jarg7);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_4")]
  public static extern global::System.IntPtr new_Teacher__SWIG_4(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5, char jarg6);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_5")]
  public static extern global::System.IntPtr new_Teacher__SWIG_5(string jarg1, string jarg2, string jarg3, string jarg4, string jarg5);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_6")]
  public static extern global::System.IntPtr new_Teacher__SWIG_6(string jarg1, string jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_7")]
  public static extern global::System.IntPtr new_Teacher__SWIG_7(string jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_8")]
  public static extern global::System.IntPtr new_Teacher__SWIG_8(string jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_9")]
  public static extern global::System.IntPtr new_Teacher__SWIG_9(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Teacher__SWIG_10")]
  public static extern global::System.IntPtr new_Teacher__SWIG_10();

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_setCourse")]
  public static extern void Teacher_setCourse(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_getCourse")]
  public static extern string Teacher_getCourse(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_setTID")]
  public static extern void Teacher_setTID(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_getTID")]
  public static extern string Teacher_getTID(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_setSalary")]
  public static extern void Teacher_setSalary(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_getSalary")]
  public static extern string Teacher_getSalary(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_delete_Teacher")]
  public static extern void delete_Teacher(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_new_Administrator")]
  public static extern global::System.IntPtr new_Administrator();

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_delete_Administrator")]
  public static extern void delete_Administrator(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Person_SWIGUpcast")]
  public static extern global::System.IntPtr Person_SWIGUpcast(global::System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Student_SWIGUpcast")]
  public static extern global::System.IntPtr Student_SWIGUpcast(global::System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Teacher_SWIGUpcast")]
  public static extern global::System.IntPtr Teacher_SWIGUpcast(global::System.IntPtr jarg1);

  [global::System.Runtime.InteropServices.DllImport("FLEX", EntryPoint="CSharp_Administrator_SWIGUpcast")]
  public static extern global::System.IntPtr Administrator_SWIGUpcast(global::System.IntPtr jarg1);
}
