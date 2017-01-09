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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            if (tf_login_id.Text.Length == 0 || tf_login_pw.Text.Length == 0) materialLabel2.Text = "아이디/비밀번호를 입력하세요";
            else
            {
                var settings = new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
                };
                var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);
                var login = new LoginData
                {
                    id = tf_login_id.Text,
                    password = SHA256_Encryptor.SHA256Hash(tf_login_pw.Text)
                };
                var result = await service.Login(login);

                if (result.status == 2)
                {
                    //success
                }
                else
                {
                    materialLabel2.Text = "로그인에 실패했습니다.";
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void tf_login_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitButton.PerformClick();
            }
        }

        private void tf_login_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitButton.PerformClick();
            }
        }
    }
}