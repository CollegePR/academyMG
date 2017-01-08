using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Retrofit.Net.Attributes.Methods;
using Retrofit.Net.Attributes.Parameters;

namespace MaterialSkinExample.RetrofitService
{
    public interface RegisterService
    {
        [Post("/api/register")]
        RestResponse<List<RegisterData>> Register([Body] RegisterData register);
    }
}
