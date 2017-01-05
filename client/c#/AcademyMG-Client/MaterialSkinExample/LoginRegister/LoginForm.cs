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
            if (IDInputfield.Text.Length == 0 || PWInputfield.Text.Length == 0) materialLabel2.Text = "아이디/비밀번호를 입력하세요";
            else
            {
                //RestAdapter adapter = new RestAdapter("http://192.168.1.51:5013/");
                RestAdapter adapter = new RestAdapter("http://192.168.0.16:5013/");
                IDCheckService service = adapter.Create<IDCheckService>();
                RestResponse<List<Response>> IDcheckResponse = service.IDCheck("test");


                materialLabel1.Text = SHA256_Encryptor.SHA256Hash(PWInputfield.Text);

                if (IDcheckResponse.Data[0].flag == true) materialLabel2.Text = "true";
                else materialLabel2.Text = "false";
            }

        }
    }
}