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
using System.IO;
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
        private string TeacherID;
        private bool Addstudent_sex = true;
        private Stream Addstudent_image = new MemoryStream();
        
        private readonly MaterialSkinManager materialSkinManager;
        /*public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }*/

        public MainForm(string teacherID)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            TeacherID = teacherID;
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
                school_class = int.Parse(tf_addstudent_schoolclass.Text),
                grade = int.Parse(tf_addstudent_grade.Text),
                sos = 1,
                doa = tf_addstudent_joindate.Text,
                dor = tf_addstudent_rejoindate.Text,
                doe = tf_addstudent_outdate.Text,
                birth=tf_addstudent_birthday.Text
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

        private void lb_addstudent_searchimage_Click(object sender, EventArgs e)
        {
            string File;

            OpenFileDialog pFileDlg = new OpenFileDialog();
            //pFileDlg.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            pFileDlg.Title = "사진을 선택해 주세요.";
            if (pFileDlg.ShowDialog() == DialogResult.OK)
            {
                File = pFileDlg.FileName;
                pb_addstudent_image.Load(File);
                pb_addstudent_image.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_addstudent_image.Image.Save(Addstudent_image,pb_addstudent_image.Image.RawFormat);
            }
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab.SelectedIndex == 3)
            {
                ResetAttendList();
            }
        }

        private async void ResetAttendList()
        {
            var settings = new RefitSettings
             {
                 JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
             };
             var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var attendance_data = new MyStudentData
            {
                TeacherID = this.TeacherID
            };

            var result = await service.GetMyStudent(attendance_data);

             if (result.flag)
             {
                 foreach (StudentAttendData access_list_data in result.data)
                 {
                    if (access_list_data.check == false)
                    {
                        var data = new[] { access_list_data.id, access_list_data.name};
                        var item = new ListViewItem(data);
                        lv_attend_list.Items.Add(item);
                    }
                 }
             }
             else
             {
                 var data = new[] { "NULL", "NULL"};
                 var item = new ListViewItem(data);
                 lv_attend_list.Items.Add(item);
             }
        }

        private async void rb_attend_submit_Click(object sender, EventArgs e)
        {
            if (lv_attend_list.SelectedItems.Count > 0)
            {
                int AttendanceCheckFailCount=0;

                var settings = new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
                };
                var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

                for (int i = 0; i < lv_attend_list.SelectedItems.Count; i++)
                {
                    var attendcheck_data = new AttendanceCheckData
                    {
                        id = int.Parse(lv_attend_list.SelectedItems[i].SubItems[0].Text),
                        check = true
                    };

                    var result = await service.AttendanceCheck(attendcheck_data);

                    if (result.flag == false)
                    {
                        AttendanceCheckFailCount++;
                    }
                }

                if (AttendanceCheckFailCount > 0)
                    Util.ShowInDialog("알림", AttendanceCheckFailCount.ToString() + "명의 학생을 출석처리 하는데 실패하였습니다");

                ResetAttendList();
            }
        }
    }
}
