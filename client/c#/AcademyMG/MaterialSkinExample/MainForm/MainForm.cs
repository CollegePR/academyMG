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
                lb_addstudent_sex.Text = "여";
            else
                lb_addstudent_sex.Text = "남";
        }

        private async void rb_addstudent_submit_Click(object sender, EventArgs e)
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:8000/api/addstudent", settings);

            var add = new AddStudentData
            {
                sex = true,
                phone_num = "010-1234-4567",
                address = "서울시 홍길동 뽀로로",
                school_name = "대건 초등학교",
                school_class =  "1반",
                grade = 6,
                sos = 1
            };

            var result = await service.AddStudent(add);

            if (result.flag == true)
            {
                this.Close();
            }
            else this.Close();
        }
    }
}
