using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public TeacherSubData teacher { get; set; }
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
        public string school_class { get; set; }

        [AliasAs("grade")]
        public int grade { get; set; }

        [AliasAs("status_of_sign")]
        public int sos { get; set; }
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
        public string school_class { get; set; }

        [AliasAs("grade")]
        public int grade { get; set; }

        [AliasAs("status_of_sign")]
        public int sos { get; set; }
    }

    public class SetTeacherData
    {
        [AliasAs("id")]
        public string id { get; set; }

        [AliasAs("password")]
        public string password { get; set; }

        [AliasAs("academy_class")]
        public string academy_class { get; set; }

        [AliasAs("name")]
        public string name { get; set; }

        [AliasAs("status")]
        public int status { get; set; }
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

        //Search
        [Get("/api/search")]
        Task<SearchResponse> Search(string search_query);
    }
}