using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace Refit.Tests
{
    public class RegisterResponse
    {
        public bool flag { get; set; }
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

    [Headers("User-Agent: AcademyMG APIs Tests")]
    public interface AcademyMG_APIs
    {
        [Post("/api/register")]
        Task<RegisterResponse> Register([Body(BodySerializationMethod.UrlEncoded)] RegisterData register);
        //Task<RegisterResponse> Register(string id, string password, int academy_class, string name);
    }
}