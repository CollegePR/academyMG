﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xunit;
using Nustache;
using Nustache.Core;
using Refit.Generator;
using SomeType = CollisionA.SomeType;
using CollisionB;
using System.Net;
using System.Reactive.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RichardSzalay.MockHttp;
using System.IO;
using System.Reflection;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
#pragma warning disable 0649
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
#pragma warning restore 0649
    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIGitHubApi : IGitHubApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            return (Task<User>) methodImpls["GetUser"](Client, arguments);
        }

        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserObservable"](Client, arguments);
        }

        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserCamelCase"](Client, arguments);
        }

        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            return (Task<List<User>>) methodImpls["GetOrgMembers"](Client, arguments);
        }

        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            return (Task<UserSearchResult>) methodImpls["FindUsers"](Client, arguments);
        }

        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            return (Task<HttpResponseMessage>) methodImpls["GetIndex"](Client, arguments);
        }

        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            return (IObservable<string>) methodImpls["GetIndexObservable"](Client, arguments);
        }

        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["NothingToSeeHere"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIAmARefitInterfaceButNobodyUsesMe : IAmARefitInterfaceButNobodyUsesMe
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIAmARefitInterfaceButNobodyUsesMe(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task RefitMethod()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["RefitMethod"](Client, arguments);
        }

        public virtual Task AnotherRefitMethod()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["AnotherRefitMethod"](Client, arguments);
        }

        public virtual Task NoConstantsAllowed()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

        public virtual Task SpacesShouldntBreakMe()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["SpacesShouldntBreakMe"](Client, arguments);
        }

        public virtual Task ReservedWordsForParameterNames(int @int,string @string,float @long)
        {
            var arguments = new object[] { @int,@string,@long };
            return (Task) methodImpls["ReservedWordsForParameterNames"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIBoringCrudApi<T, TKey> : IBoringCrudApi<T, TKey>
        where T : class
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIBoringCrudApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<T> Create(T paylod)
        {
            var arguments = new object[] { paylod };
            return (Task<T>) methodImpls["Create"](Client, arguments);
        }

        public virtual Task<List<T>> ReadAll()
        {
            var arguments = new object[] {  };
            return (Task<List<T>>) methodImpls["ReadAll"](Client, arguments);
        }

        public virtual Task<T> ReadOne(TKey key)
        {
            var arguments = new object[] { key };
            return (Task<T>) methodImpls["ReadOne"](Client, arguments);
        }

        public virtual Task Update(TKey key,T payload)
        {
            var arguments = new object[] { key,payload };
            return (Task) methodImpls["Update"](Client, arguments);
        }

        public virtual Task Delete(TKey key)
        {
            var arguments = new object[] { key };
            return (Task) methodImpls["Delete"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedINamespaceCollisionApi : INamespaceCollisionApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedINamespaceCollisionApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<SomeType> SomeRequest()
        {
            var arguments = new object[] {  };
            return (Task<SomeType>) methodImpls["SomeRequest"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedINpmJs : INpmJs
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedINpmJs(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<RootObject> GetCongruence()
        {
            var arguments = new object[] {  };
            return (Task<RootObject>) methodImpls["GetCongruence"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIRequestBin : IRequestBin
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIRequestBin(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIAmHalfRefit : IAmHalfRefit
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIAmHalfRefit(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post"](Client, arguments);
        }

        public virtual Task Get()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIHttpBinApi<TResponse, TParam, THeader> : IHttpBinApi<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIHttpBinApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            return (Task<TResponse>) methodImpls["Get"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIBrokenWebApi : IBrokenWebApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIBrokenWebApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<bool> PostAValue(string derp)
        {
            var arguments = new object[] { derp };
            return (Task<bool>) methodImpls["PostAValue"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIHttpContentApi : IHttpContentApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIHttpContentApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<HttpContent> PostFileUpload(HttpContent content)
        {
            var arguments = new object[] { content };
            return (Task<HttpContent>) methodImpls["PostFileUpload"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIUseOverloadedMethods : IUseOverloadedMethods
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIUseOverloadedMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task Get()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Get"](Client, arguments);
        }

        public virtual Task Get(int id)
        {
            var arguments = new object[] { id };
            return (Task) methodImpls["Get"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIRunscopeApi : IRunscopeApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIRunscopeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<HttpResponseMessage> UploadStream(Stream stream)
        {
            var arguments = new object[] { stream };
            return (Task<HttpResponseMessage>) methodImpls["UploadStream"](Client, arguments);
        }

        public virtual Task<HttpResponseMessage> UploadBytes(byte[] bytes)
        {
            var arguments = new object[] { bytes };
            return (Task<HttpResponseMessage>) methodImpls["UploadBytes"](Client, arguments);
        }

        public virtual Task<HttpResponseMessage> UploadString(string someString)
        {
            var arguments = new object[] { someString };
            return (Task<HttpResponseMessage>) methodImpls["UploadString"](Client, arguments);
        }

        public virtual Task<HttpResponseMessage> UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            return (Task<HttpResponseMessage>) methodImpls["UploadFileInfo"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedAcademyMG_APIs : AcademyMG_APIs
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedAcademyMG_APIs(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<IDCheckResponse> IDCheck(string id)
        {
            var arguments = new object[] { id };
            return (Task<IDCheckResponse>) methodImpls["IDCheck"](Client, arguments);
        }

        public virtual Task<LoginResponse> Login(LoginData login)
        {
            var arguments = new object[] { login };
            return (Task<LoginResponse>) methodImpls["Login"](Client, arguments);
        }

        public virtual Task<RegisterResponse> Register(RegisterData register)
        {
            var arguments = new object[] { register };
            return (Task<RegisterResponse>) methodImpls["Register"](Client, arguments);
        }

        public virtual Task<AddStudentResponse> AddStudent(AddStudentData student)
        {
            var arguments = new object[] { student };
            return (Task<AddStudentResponse>) methodImpls["AddStudent"](Client, arguments);
        }

        public virtual Task<SetStudentResponse> SetStudent(SetStudentData student)
        {
            var arguments = new object[] { student };
            return (Task<SetStudentResponse>) methodImpls["SetStudent"](Client, arguments);
        }

        public virtual Task<SetTeacherResponse> SetTeacher(SetTeacherData teacher)
        {
            var arguments = new object[] { teacher };
            return (Task<SetTeacherResponse>) methodImpls["SetTeacher"](Client, arguments);
        }

        public virtual Task<AdmissionStatusResponse> GetAdmissionStatus(AdmissionStatusData data)
        {
            var arguments = new object[] { data };
            return (Task<AdmissionStatusResponse>) methodImpls["GetAdmissionStatus"](Client, arguments);
        }

        public virtual Task<SearchResponse> Search(string search_query)
        {
            var arguments = new object[] { search_query };
            return (Task<SearchResponse>) methodImpls["Search"](Client, arguments);
        }

        public virtual Task<AccessListResponse> GetAccessList()
        {
            var arguments = new object[] {  };
            return (Task<AccessListResponse>) methodImpls["GetAccessList"](Client, arguments);
        }

        public virtual Task<AttendanceCheckResponse> AttendanceCheck(AttendanceCheckData acdata)
        {
            var arguments = new object[] { acdata };
            return (Task<AttendanceCheckResponse>) methodImpls["AttendanceCheck"](Client, arguments);
        }

        public virtual Task<AttendanceStatusResponse> GetAttendanceStatus(AttendanceStatusData asdata)
        {
            var arguments = new object[] { asdata };
            return (Task<AttendanceStatusResponse>) methodImpls["GetAttendanceStatus"](Client, arguments);
        }

        public virtual Task<ClassListResponse> GetClassList()
        {
            var arguments = new object[] {  };
            return (Task<ClassListResponse>) methodImpls["GetClassList"](Client, arguments);
        }

        public virtual Task<GetClassNameResponse> GetClassName(int academy_class)
        {
            var arguments = new object[] { academy_class };
            return (Task<GetClassNameResponse>) methodImpls["GetClassName"](Client, arguments);
        }

        public virtual Task<MyStudentAttendanceResponse> GetMyStudent(MyStudentData msdata)
        {
            var arguments = new object[] { msdata };
            return (Task<MyStudentAttendanceResponse>) methodImpls["GetMyStudent"](Client, arguments);
        }

        public virtual Task<ImageResponse> ImageUpload(Stream image)
        {
            var arguments = new object[] { image };
            return (Task<ImageResponse>) methodImpls["ImageUpload"](Client, arguments);
        }

    }
}
