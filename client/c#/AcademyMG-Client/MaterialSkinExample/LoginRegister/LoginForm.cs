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
using MaterialSkinExample.RetrofitService;
using MaterialSkin.Controls;
using RestSharp;
using Retrofit.Net;
using MaterialSkinExample.Encrypter;

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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (tf_login_id.Text.Length == 0 || tf_login_pw.Text.Length == 0) materialLabel2.Text = "아이디/비밀번호를 입력하세요";
            else
            {
                RestAdapter adapter = new RestAdapter("http://127.0.0.1:5013/");
                IDCheckService service = adapter.Create<IDCheckService>();
                RestResponse<List<Response>> IDcheckResponse = service.IDCheck("test");


                //materialLabel1.Text = SHA256_Encryptor.SHA256Hash(tf_login_pw.Text);

                if (IDcheckResponse.Data[0].flag == true) materialLabel2.Text = "true";
                else materialLabel2.Text = "false";
            }

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}