using System.Collections.Generic;
using RestSharp;
using Retrofit.Net.Attributes.Methods;
using Retrofit.Net.Attributes.Parameters;

namespace MaterialSkinExample
{
    public interface TestService
    {
        [Get("/weather/code/grid")]
        RestResponse<List<Weather>> GetWeather([Query("version")] int version, [Query("lon")] float lon, [Query("lat")] float lat);
    }
}