using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Refit;

namespace Refit.Tests
{
    #region Response
    public class IDCheckResponse
    {
        public bool flag { get; set; }
    }

    public class LoginResponse
    {
        public int status { get; set; }
        public bool flag { get; set; }
        public TeacherSubData data { get; set; }
    }

    public class RegisterResponse
    {
        public bool flag { get; set; }
    }

    public class AddStudentResponse
    {
        public bool flag { get; set; }
    }

    public class SetStudentResponse
    {
        public bool flag { get; set; }
    }

    public class SetTeacherResponse
    {
        public bool flag { get; set; }
    }

    public class SearchResponse
    {
        public bool flag { get; set; }
        public int count { get; set; }
        public SearchSubData[] data { get; set; }
    }

    public class AccessListResponse
    {
        public bool flag { get; set; }
        public AccessListSubData[] data { get; set; }
    }

    public class AttendanceCheckResponse
    {
        public bool flag { get; set; }
    }

    public class AttendanceStatusResponse
    {
        public bool flag { get; set; }
        public StudentAttendStatusData[] data { get; set; }
    }

    public class AdmissionStatusResponse
    {
        public bool flag { get; set; }
    }

    public class ClassListResponse
    {
        public bool flag { get; set; }
        public ClassListSubData[] data { get; set; }
    }

    public class GetClassNameResponse
    {
        public bool flag { get; set; }
        public GetClassNameSubData data { get; set; }
    }

    public class MyStudentAttendanceResponse
    {
        public bool flag { get; set; }
        public StudentAttendData[] data { get; set; }
    }

    public class ImageResponse
    {
        public bool flag { get; set; }
    }

    #endregion

    #region SendData
    public class LoginData
    {
        [AliasAs("id")]
        public string id { get; set; }

        [AliasAs("password")]
        public string password { get; set; }
    }

    public class RegisterData
    {
        [AliasAs("id")]
        public string id { get; set; }

        [AliasAs("password")]
        public string password { get; set; }

        [AliasAs("academy_class")]
        public int academy_class { get; set; }

        [AliasAs("name")]
        public string name { get; set; }
    }

    public class AddStudentData
    {
        [AliasAs("name")]
        public string name { get; set; }

        [AliasAs("sex")]
        public bool sex { get; set; }

        [AliasAs("phone_num")]
        public string phone_num { get; set; }

        [AliasAs("address")]
        public string address { get; set; }

        [AliasAs("school_name")]
        public string school_name { get; set; }

        [AliasAs("school_class")]
        public int school_class { get; set; }

        [AliasAs("grade")]
        public int grade { get; set; }

        [AliasAs("status_of_sign")]
        public int sos { get; set; }

        [AliasAs("date_of_admission")]
        public string doa { get; set; }

        [AliasAs("date_of_readdmission")]
        public string dor { get; set; }

        [AliasAs("date_of_exit")]
        public string doe { get; set; }

        [AliasAs("birthday")]
        public string birth { get; set; }

        [AliasAs("academy_class")]
        public int academy_class { get; set; }
    }

    public class SetStudentData
    {
        [AliasAs("id")]
        public int id { get; set; }

        [AliasAs("name")]
        public string name { get; set; }

        [AliasAs("sex")]
        public bool sex { get; set; }

        [AliasAs("phone_num")]
        public string phone_num { get; set; }

        [AliasAs("address")]
        public string address { get; set; }

        [AliasAs("school_name")]
        public string school_name { get; set; }

        [AliasAs("school_class")]
        public int school_class { get; set; }

        [AliasAs("grade")]
        public int grade { get; set; }

        [AliasAs("status_of_sign")]
        public int sos { get; set; }

        [AliasAs("date_of_admission")]
        public string doa { get; set; }

        [AliasAs("date_of_readdmission")]
        public string dor { get; set; }

        [AliasAs("date_of_exit")]
        public string doe { get; set; }

        [AliasAs("birthday")]
        public string birth { get; set; }

        [AliasAs("academy_class")]
        public int academy_class { get; set; }

    }

    public class SetTeacherData
    {
        [AliasAs("id")]
        public string id { get; set; }

        [AliasAs("password")]
        public string password { get; set; }

        [AliasAs("academy_class")]
        public int academy_class { get; set; }

        [AliasAs("name")]
        public string name { get; set; }

        [AliasAs("status")]
        public int status { get; set; }
    }

    public class AttendanceCheckData
    {
        [AliasAs("id")]
        public int id { get; set; }

        [AliasAs("check")]
        public bool check { get; set; }
    }

    public class AttendanceStatusData
    {
        [AliasAs("id")]
        public int id { get; set; }
    }

    public class AdmissionStatusData
    {
        [AliasAs("id")]
        public string id { get; set; }

        [AliasAs("status")]
        public int status { get; set; }
    }

    public class MyStudentData
    {
        [AliasAs("requestId")]
        public string TeacherID { get; set; }
    }

    #endregion

    #region SubData
    public class TeacherSubData
    {
        public int academy_class { get; set; }
        public string name { get; set; }
    }

    public class SearchSubData
    {
        public int id { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public bool sex { get; set; }
        public string phone_num { get; set; }
        public string address { get; set; }
        public string school_name { get; set; }
        public int school_class { get; set; }
        public int grade { get; set; }
        public int status_of_sign { get; set; }
        public string date_of_admission { get; set; }
        public string date_of_readdmission { get; set; }
        public string date_of_exit { get; set; }
        public string birthday { get; set; }
        public int academy_class { get; set; }
    }

    public class AccessListSubData
    {
        public string name { get; set; }
        public string id { get; set; }
        public int academy_class { get; set; }
    }

    public class ClassListSubData
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class GetClassNameSubData
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class StudentAttendData
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool check { get; set; }
    }

    public class StudentAttendStatusData
    {
        public string date { get; set; }
        public bool isAttend { get; set; }
    }

    #endregion

    [Headers("User-Agent: AcademyMG APIs Tests")]
    public interface AcademyMG_APIs
    {
        //IDCheck
        [Get("/api/idcheck")]
        Task<IDCheckResponse> IDCheck(string id);

        //Login
        [Post("/api/login")]
        Task<LoginResponse> Login([Body(BodySerializationMethod.UrlEncoded)] LoginData login);

        //Register
        [Post("/api/register")]
        Task<RegisterResponse> Register([Body(BodySerializationMethod.UrlEncoded)] RegisterData register);

        //AddStudent
        [Post("/api/addstudent")]
        Task<AddStudentResponse> AddStudent([Body(BodySerializationMethod.UrlEncoded)] AddStudentData student);

        //SetStudent
        [Post("/api/setstudent")]
        Task<SetStudentResponse> SetStudent([Body(BodySerializationMethod.UrlEncoded)] SetStudentData student);

        //SetTeacher
        [Post("/api/setteacher")]
        Task<SetTeacherResponse> SetTeacher([Body(BodySerializationMethod.UrlEncoded)] SetTeacherData teacher);

        //Status Admission
        [Post("/api/setteacher")]
        Task<AdmissionStatusResponse> GetAdmissionStatus([Body(BodySerializationMethod.UrlEncoded)] AdmissionStatusData data);

        //Search
        [Get("/api/search")]
        Task<SearchResponse> Search(string search_query);

        //AccessList
        [Get("/api/accesslist")]
        Task<AccessListResponse> GetAccessList();

        //AttendanceCheck
        [Post("/api/attendancecheck")]
        Task<AttendanceCheckResponse> AttendanceCheck([Body(BodySerializationMethod.UrlEncoded)] AttendanceCheckData acdata);

        //AttendanceStatus
        [Post("/api/attendancestatus")]
        Task<AttendanceStatusResponse> GetAttendanceStatus([Body(BodySerializationMethod.UrlEncoded)] AttendanceStatusData asdata);

        //ClassList
        [Get("/api/classlist")]
        Task<ClassListResponse> GetClassList();

        //ClassName
        [Get("/api/getclassname")]
        Task<GetClassNameResponse> GetClassName(int academy_class);

        [Post("/api/mystudentattendance")]
        Task<MyStudentAttendanceResponse> GetMyStudent([Body(BodySerializationMethod.UrlEncoded)] MyStudentData msdata);

        [Multipart]
        [Post("/api/imageupload")]
        Task<ImageResponse> ImageUpload([AttachmentName("test.png")] Stream image);
    }
}