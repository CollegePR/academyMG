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
using MaterialSkinExample.RetrofitService;
using RestSharp;
using Retrofit.Net;
using MaterialSkinExample.Encrypter;
using System.Web;

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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            RestAdapter adapter = new RestAdapter("http://127.0.0.1:5013/");
            RegisterService service = adapter.Create<RegisterService>();
            RestResponse<List<RegisterData>> result = service.Register(new RegisterData { id = HttpUtility.UrlEncode("testid"), password = HttpUtility.UrlEncode("testpw"), academy_class = 1, name = HttpUtility.UrlEncode("test") });

            

            //materialLabel1.Text = SHA256_Encryptor.SHA256Hash(tf_login_pw.Text);

            //if (result.Data[0].flag == true) this.Close();
            //else materialLabel5.Text = result.ErrorMessage;
        }
    }
}
