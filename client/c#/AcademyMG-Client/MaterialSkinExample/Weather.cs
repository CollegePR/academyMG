using System.Collections.Generic;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Retrofit.Net;

namespace MaterialSkinExample
{
    public class Weather
    {
        public ErrorCode error { get; set; }
    }
    public class ErrorCode
    {
        public string category { get; set; }
        public string code { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public string message { get; set; }
    }
}