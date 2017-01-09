using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RestSharp;
using MaterialSkinExample.Encrypter;
using System.Web;
using Refit;

using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Xunit;
using RichardSzalay.MockHttp;

using Refit.Tests;

namespace MaterialSkinExample.LoginRegister
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void tf_register_class_Click(object sender, EventArgs e)
        {
            
        }

        private void tf_register_id_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var register = new RegisterData
            {
                id = "testid",
                password = SHA256_Encryptor.SHA256Hash("testpw"),
                academy_class = 1,
                name = "test"
            };

            var result = await service.Register(register);
        }
    }
}
