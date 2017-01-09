using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Refit.Tests
{
    #region Response
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
    #endregion

    #region SubData
    public class TeacherSubData
    {
        public int academy_class { get; set; }
        public string name { get; set; }
    }
    #endregion


    [Headers("User-Agent: AcademyMG APIs Tests")]
    public interface AcademyMG_APIs
    {
        //Login
        [Post("/api/login")]
        Task<LoginResponse> Login([Body(BodySerializationMethod.UrlEncoded)] LoginData login);

        //Register
        [Post("/api/register")]
        Task<RegisterResponse> Register([Body(BodySerializationMethod.UrlEncoded)] RegisterData register);
    }
}