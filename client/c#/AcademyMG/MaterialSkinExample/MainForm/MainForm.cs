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

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private bool Addstudent_sex;

        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void lb_addstudent_sex_Click(object sender, EventArgs e) // 원생 추가
        {
            if (lb_addstudent_sex.Text == "남")
                lb_addstudent_sex.Text = "여";
            else
                lb_addstudent_sex.Text = "남";
        }

        private void lb_renewstudent_sex_Click(object sender, EventArgs e) // 원생 갱신
        {
            if (lb_addstudent_sex.Text == "남")
            {
                lb_addstudent_sex.Text = "여";
                Addstudent_sex = false;
            }
            else
            {
                lb_addstudent_sex.Text = "남";
                Addstudent_sex = true;
            }
        }

        private async void rb_addstudent_submit_Click(object sender, EventArgs e)
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var add = new AddStudentData
            {
                name = tf_addstudent_name.Text,
                sex = Addstudent_sex,
                phone_num = tf_addstudent_phone.Text,
                address = tf_addstudent_address.Text,
                school_name = tf_addstudent_schoolname.Text,
                school_class =  int.Parse(tf_addstudent_schoolclass.Text),
                grade = int.Parse(tf_addstudent_grade.Text),
                sos = 1
            };

            var result = await service.AddStudent(add);

            if (result.flag == true)
            {
                this.Close();
            }
            else this.Close();
        }

        private void tf_addstudent_joindate_Click(object sender, EventArgs e)
        {
            tf_addstudent_joindate.Text=Util.SelectDate();
        }

        private void tf_addstudent_rejoindate_Click(object sender, EventArgs e)
        {
            tf_addstudent_rejoindate.Text = Util.SelectDate();
        }

        private void tf_addstudent_outdate_Click(object sender, EventArgs e)
        {
            tf_addstudent_outdate.Text = Util.SelectDate();
        }

        private void tf_addstudent_birthday_Click(object sender, EventArgs e)
        {
            tf_addstudent_birthday.Text = Util.SelectDate();
        }

        private void tf_addstudent_joindate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_addstudent_rejoindate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_addstudent_outdate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_addstudent_birthday_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_renewstudent_joindate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_renewstudent_rejoindate_Click(object sender, EventArgs e)
        {
            tf_renewstudent_rejoindate.Text = Util.SelectDate();
        }

        private void tf_renewstudent_joindate_Click(object sender, EventArgs e)
        {
            tf_renewstudent_joindate.Text = Util.SelectDate();
        }

        private void tf_renewstudent_outdate_Click(object sender, EventArgs e)
        {
            tf_renewstudent_outdate.Text = Util.SelectDate();
        }

        private void tf_renewstudent_birthday_Click(object sender, EventArgs e)
        {
            tf_renewstudent_birthday.Text = Util.SelectDate();
        }

        private void tf_renewstudent_rejoindate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_renewstudent_outdate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_renewstudent_birthday_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_renewstudent_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
