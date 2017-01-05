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
    public interface IDCheckService
    {
        [Get("/api/idcheck")]
        RestResponse<List<Response>> IDCheck([Query("id")] string id);
    }
}
