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
        public bool id_check_result = false;
        public bool pw_check_result = false;
        public bool pwcmp_check_result = false;
        public bool name_check_result = false;
        public bool class_check_result = false;

        public int class_id = -1;

        public class InputCheck
        {
            public bool flag { get; set; }
            public string err_msg { get; set; }
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!id_check_result) materialLabel6.Text = "아이디 중복 오류";
            else
            {
                if (!pw_check_result) materialLabel6.Text = "패스워드 오류";
                else
                {
                    if (!pwcmp_check_result) materialLabel6.Text = "패스워드 확인 오류";
                    else
                    {
                        if (!name_check_result) materialLabel6.Text = "이름 오류";
                        else
                        {
                            if (!class_check_result) materialLabel6.Text = "학급명 오류";
                            else
                            {
                                register_process();
                            }
                        }
                    }
                }
            }
        }

        private void tf_register_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
            else id_check_process();
        }

        private void tf_register_id_KeyUp(object sender, KeyEventArgs e)
        {
            id_check_process();
        }

        private void tf_register_id_Leave(object sender, EventArgs e)
        {
            id_check_process();
        }

        private void tf_register_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
            else pw_check_process();
        }

        private void tf_register_pw_KeyUp(object sender, KeyEventArgs e)
        {
            pw_check_process();
        }

        private void tf_register_pwcmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
            else pwcmp_check_process();
        }

        private void tf_register_pwcmp_KeyUp(object sender, KeyEventArgs e)
        {
            pwcmp_check_process();
        }

        private void tf_register_pwcmp_Leave(object sender, EventArgs e)
        {
            pwcmp_check_process();
        }
        
        private void tf_register_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
            else name_check_process();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void id_check_process()
        {
            id_check_result = false;
            InputCheck check = register_id_check(tf_register_id.Text);
            if (check.flag)
            {
                materialLabel1.Text = "";
                var settings = new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
                };
                var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);
                var result = await service.IDCheck(tf_register_id.Text);

                if (result.flag) materialLabel1.Text = "중복된 아이디입니다.";
                else
                {
                    materialLabel1.Text = "사용가능한 아이디입니다.";
                    id_check_result = true;
                }
            }
            else materialLabel1.Text = check.err_msg;
        }

        private void pw_check_process()
        {
            pw_check_result = false;
            InputCheck check = register_pw_check(tf_register_pw.Text);
            if (check.flag)
            {
                materialLabel3.Text = "사용가능한 비밀번호입니다.";
                pw_check_result = true;
            }
            else materialLabel3.Text = check.err_msg;
        }

        private void pwcmp_check_process()
        {
            pwcmp_check_result = false;
            if (tf_register_pwcmp.Text.Equals(tf_register_pw.Text))
            {
                materialLabel4.Text = "비밀번호가 일치합니다.";
                pwcmp_check_result = true;
            }
            else materialLabel4.Text = "비밀번호가 일치하지 않습니다.";
        }

        private void name_check_process()
        {
            name_check_result = false;
            materialLabel2.Text = "사용가능한 이름입니다.";
            name_check_result = true;
        }

        private void class_check_process()
        {
            class_check_result = false;
            if (tf_register_class.Text.Length != 0 && class_id != -1) class_check_result = true;
        }

        private async void register_process()
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var result1 = await service.IDCheck(tf_register_id.Text);

            if (!result1.flag)
            {
                var register = new RegisterData
                {
                    id = tf_register_id.Text,
                    password = SHA256_Encryptor.SHA256Hash(tf_register_pw.Text),
                    academy_class = class_id,
                    name = tf_register_name.Text
                };

                var result = await service.Register(register);

                if (result.flag == true)
                {
                    this.Close();
                }
                else materialLabel6.Text = "회원가입 실패[REGISTER_ERROR]";
            }
            else materialLabel6.Text = "회원가입 실패[ID_CHECK_ERROR]";
        }

        private InputCheck register_id_check(string id)
        {
            bool flag = false;
            string msg = "";

            if (id.Length < 4) msg = "아이디는 4글자 이상이어야 합니다.";
            else if (id.Length >= 16) msg = "아이디는 16글자 미만이어야 합니다.";
            else
            {
                foreach (char chr in id)
                {
                    if (!((chr >= '0' && chr <= '9') || (chr >= 'a' && chr <= 'z') || (chr >= 'A' && chr <= 'Z'))) msg = "아이디는 특수문자를 포함할 수 없습니다.";
                }
            }
            if (msg.Length == 0) flag = true;

            return new InputCheck { flag = flag, err_msg = msg };
        }

        private InputCheck register_pw_check(string pw)
        {
            bool flag = false;
            string msg = "사용가능한 비밀번호 입니다.";

            if (pw.Length < 8) msg = "비밀번호는 8글자 이상이어야 합니다.";
            else if (pw.Length >= 16) msg = "비밀번호는 16글자 미만이어야 합니다.";
            else flag = true;

            return new InputCheck { flag = flag, err_msg = msg };
        }

        private void tf_register_class_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tf_register_class_Enter(object sender, EventArgs e)
        {
            show_class_select_form();
        }

        private void tf_register_class_Click(object sender, EventArgs e)
        {
            show_class_select_form();
        }

        private void tf_register_class_Leave(object sender, EventArgs e)
        {
            class_check_process();
        }

        private void show_class_select_form()
        {
            SelectClassForm selectclassForm = new SelectClassForm(this, tf_register_class);
            selectclassForm.ShowDialog();
        }

        private void tf_register_class_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SubmitButton.PerformClick();
        }
    }
}
