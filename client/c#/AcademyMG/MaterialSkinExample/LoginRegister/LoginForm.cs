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
        public class InputCheck
        {
            public bool flag { get; set; }
            public string err_msg { get; set; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            if (tf_login_id.Text.Equals("admin"))
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.ShowDialog();
                this.Close();
            }
            else
            {
                InputCheck check = login_id_check(tf_login_id.Text);

                if (check.flag)
                {
                    materialLabel2.Text = "";
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

                    if (result.flag)
                    {
                        materialLabel2.Text = "로그인 되었습니다.";

                        MainForm mainForm = new MainForm(tf_login_id.Text,result.data.academy_class);
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        materialLabel2.Text = "로그인에 실패했습니다.";
                    }
                }
                else materialLabel2.Text = check.err_msg;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void tf_login_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
        }

        private void tf_login_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
        }

        private InputCheck login_id_check(string id)
        {
            bool flag = false;
            string msg = "";

            if (id.Length < 4) msg = "아이디는 4글자 이상이어야 합니다.";
            else if (id.Length >= 16) msg = "아이디는 16글자 미만이어야 합니다.";
            else
            {
                foreach(char chr in id)
                {
                    if (!((chr >= '0' && chr <= '9') || (chr >= 'a' && chr <= 'z') || (chr >= 'A' && chr <= 'Z'))) msg = "아이디는 특수문자를 포함할 수 없습니다.";
                }
            }
            if (msg.Length == 0) flag = true;

            return new InputCheck { flag = flag, err_msg = msg };
        }

        private InputCheck login_pw_check(string pw)
        {
            bool flag = false;
            string msg = "";

            if (pw.Length < 8) msg = "비밀번호는 8글자 이상이어야 합니다.";
            else if (pw.Length >= 16) msg = "비밀번호는 16글자 미만이어야 합니다.";
            else flag = true;

            return new InputCheck { flag = flag, err_msg = msg };
        }
    }
}