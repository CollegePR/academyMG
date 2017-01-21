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
using MaterialSkinExample.LoginRegister;
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
        private int myclass_id;
        private bool Addstudent_sex = true;
        private bool Renewstudent_sex = true;
        public int class_id = -1;

        static int key = -1; // 사용자가 몇 번째 사람을 선택했는지 
        static int key2 = 0;//메인화면 퇴소처리 저장용 키값
        static int key3 = 0;//id값 가져오는거
        static bool main_sex = true; //원생 검색용 성별

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
        public MainForm(int key_code)
        {
            key = key_code;
        }

        public MainForm(string teacherID,int myclass_id)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            TeacherID = teacherID;
            this.myclass_id = myclass_id;
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
                birth = tf_addstudent_birthday.Text,
                academy_class = class_id
            };

            var dataresult = await service.AddStudent(add);

            if (dataresult.flag == true)
            {
                Util.ShowInDialog("알림", "원생추가 성공");
                {
                    tf_addstudent_name.Text = "";
                    lb_addstudent_sex.Text = "남";
                    Addstudent_sex = true;
                    tf_addstudent_phone.Text = "";
                    tf_addstudent_address.Text = "";
                    tf_addstudent_schoolname.Text = "";
                    tf_addstudent_grade.Text = "";
                    tf_addstudent_schoolclass.Text = "";
                    tf_addstudent_joindate.Text = "";
                    tf_addstudent_rejoindate.Text = "";
                    tf_addstudent_outdate.Text = "";
                    tf_addstudent_lecture.Text = "";
                    class_id = -1;
                    tf_addstudent_birthday.Text = "";
                }
            }
            else
            {
                Util.ShowInDialog("알림", "원생추가 실패");
            }

            /*var imageresult = await service.ImageUpload(Addstudent_image);

            if (imageresult.flag)
            {
                Util.ShowInDialog("알림", "이미지 실패");
            }
            else
            {
                Util.ShowInDialog("알림", "이미지 성공");
            }*/
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

        private async void tf_renewstudent_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var settings = new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
                };

                var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

                var result = await service.Search(tf_renewstudent_search.Text);

                if (result.flag)
                {
                    if (result.count == 1)
                    {
                        key3 = result.data[0].id;
                        tf_renewstudent_phone.Text = result.data[0].phone_num;
                        tf_renewstudent_address.Text = result.data[0].address;
                        tf_renewstudent_schoolName.Text = result.data[0].school_name;
                        tf_renewstudent_grade.Text = result.data[0].grade.ToString();
                        tf_renewstudent_schoolclass.Text = result.data[0].school_class.ToString();
                        tf_renewstudent_joindate.Text = result.data[0].date_of_admission;
                        tf_renewstudent_rejoindate.Text = result.data[0].date_of_readdmission;
                        tf_renewstudent_outdate.Text = result.data[0].date_of_exit;
                        tf_renewstudent_name.Text = result.data[0].name;
                        tf_renewstudent_lecture.Text = Convert.ToString(result.data[0].academy_class);
                        tf_renewstudent_birthday.Text = result.data[0].birthday;
                    }

                    else if (result.count == 0)
                    {
                        //찾는 사람 이름이 존재하지 않을 때
                    }

                    else//여러명 일때
                    {
                        new Form1(tf_renewstudent_search.Text).ShowDialog();

                        for (int i = 0; i < result.count; i++)
                        {
                            if (key == result.data[i].id)
                            {
                                tf_renewstudent_phone.Text = result.data[i].phone_num;
                                tf_renewstudent_address.Text = result.data[i].address;
                                tf_renewstudent_schoolName.Text = result.data[i].school_name;
                                tf_renewstudent_grade.Text = result.data[i].grade.ToString();
                                tf_renewstudent_schoolclass.Text = result.data[i].school_class.ToString();
                                tf_renewstudent_joindate.Text = result.data[i].date_of_admission;
                                tf_renewstudent_rejoindate.Text = result.data[i].date_of_readdmission;
                                tf_renewstudent_outdate.Text = result.data[i].date_of_exit;
                                tf_renewstudent_name.Text = result.data[i].name;
                                tf_renewstudent_lecture.Text = Convert.ToString(result.data[i].academy_class);
                                tf_renewstudent_birthday.Text = result.data[i].birthday;

                                key3 = result.data[i].id;
                                key2 = i;
                            }
                        }
                    }
                }

                else
                {
                }
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
            lv_attend_list.Items.Clear();
            
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };
            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var result = await service.Search("academy_class="+myclass_id.ToString());

            if (result.flag)
            {
                if (result.count > 0)
                {
                    for(int i = 0; i < result.count; i++)
                    {
                        var attendance_status = new AttendanceStatusData
                        {
                            id = result.data[i].id
                        };

                        var attendance_status_result = await service.GetAttendanceStatus(attendance_status);
                        if (attendance_status_result.data.Length > 0)
                        {
                            if (attendance_status_result.data[0].date != System.DateTime.Now.ToString("yyyy-MM-dd"))
                            {
                                var data = new[] { result.data[i].id.ToString(), result.data[i].name.ToString() };
                                var item = new ListViewItem(data);
                                lv_attend_list.Items.Add(item);
                            }
                        }
                        else
                        {
                            var data = new[] { result.data[i].id.ToString(), result.data[i].name.ToString() };
                            var item = new ListViewItem(data);
                            lv_attend_list.Items.Add(item);
                        }
                    }
                }
                else
                {
                    Util.ShowInDialog("알림", "학생목록 불러오기 실패");
                    var data = new[] { "NULL", "NULL" };
                    var item = new ListViewItem(data);
                    lv_attend_list.Items.Add(item);
                }
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

                //lv_attend_list.Clear();
                ResetAttendList();
            }
        }

        private void tf_addstudent_lecture_Click(object sender, EventArgs e)
        {
            SelectClassForm selectclassForm = new SelectClassForm(this, tf_addstudent_lecture);
            selectclassForm.ShowDialog();
        }

        private async void tf_mainpage_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var settings = new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
                };

                var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

                var result = await service.Search(tf_mainpage_search.Text);

                if (result.flag)
                {
                    if (result.count == 1)
                    {
                        key3 = result.data[0].id;
                        main_sex = result.data[0].sex;
                        lb_mainpage_phone.Text = result.data[0].phone_num;
                        lb_mainpage_address.Text = result.data[0].address;
                        lb_mainpage_school.Text = result.data[0].school_name;
                        lb_mainpage_grade.Text = result.data[0].grade.ToString();
                        lb_mainpage_shoolclass.Text = result.data[0].school_class.ToString();
                        lb_mainpage_join.Text = result.data[0].date_of_admission;
                        lb_mainpage_rejoindate.Text = result.data[0].date_of_readdmission;
                        lb_mainpage_outdate.Text = result.data[0].date_of_exit;
                        lb_mainpage_name.Text = result.data[0].name;
                        lb_mainpage_lecture.Text = Convert.ToString(result.data[0].academy_class);
                        lb_mainpage_birthday.Text = result.data[0].birthday;
                    }

                    else if (result.count == 0)
                    {
                        //찾는 사람 이름이 존재하지 않을 때
                    }

                    else
                    {
                        new Form1(tf_mainpage_search.Text).ShowDialog();


                        for (int i = 0; i < result.count; i++)
                        {
                            if (key == result.data[i].id)
                            {
                                key3 = result.data[i].id;
                                main_sex = result.data[i].sex;
                                lb_mainpage_phone.Text = result.data[i].phone_num;
                                lb_mainpage_address.Text = result.data[i].address;
                                lb_mainpage_school.Text = result.data[i].school_name;
                                lb_mainpage_grade.Text = result.data[i].grade.ToString();
                                lb_mainpage_shoolclass.Text = result.data[i].school_class.ToString();
                                lb_mainpage_join.Text = result.data[i].date_of_admission;
                                lb_mainpage_rejoindate.Text = result.data[i].date_of_readdmission;
                                lb_mainpage_outdate.Text = result.data[i].date_of_exit;
                                lb_mainpage_name.Text = result.data[i].name;
                                lb_mainpage_lecture.Text = Convert.ToString(result.data[i].academy_class);
                                lb_mainpage_birthday.Text = result.data[i].birthday;

                                key2 = i;
                            }
                        }

                    }

                    if (main_sex == true)
                        materialLabel1.Text = "남";
                    else
                        materialLabel1.Text = "여";
                }

                else
                {
                    //flag false
                }
            }
        }

        private async void rb_mainpage_ban_Click(object sender, EventArgs e)
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            lb_mainpage_outdate.Text = DateTime.Now.ToShortDateString();//오늘 날짜 받아오기

            var add = new SetStudentData
            {
                id = key3,
                name = lb_mainpage_name.Text,
                sex = main_sex,
                phone_num = lb_mainpage_phone.Text,
                address = lb_mainpage_address.Text,
                school_name = lb_mainpage_school.Text,
                school_class = int.Parse(lb_mainpage_shoolclass.Text),
                grade = int.Parse(lb_mainpage_grade.Text),
                sos = 1,
                doa = lb_mainpage_join.Text,
                dor = lb_mainpage_rejoindate.Text,
                doe = DateTime.Now.ToShortDateString(),
                birth = lb_mainpage_birthday.Text
            };

            var result = await service.SetStudent(add);
        }

        private async void rb_renewstudent_submit_Click(object sender, EventArgs e)
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var add = new SetStudentData
            {
                id = key3,
                name = tf_renewstudent_name.Text,
                sex = Renewstudent_sex,
                phone_num = tf_renewstudent_phone.Text,
                address = tf_renewstudent_address.Text,
                school_name = tf_renewstudent_schoolName.Text,
                school_class = int.Parse(tf_renewstudent_schoolclass.Text),
                grade = int.Parse(tf_renewstudent_grade.Text),
                sos = 1,
                doa = tf_renewstudent_joindate.Text,
                dor = tf_renewstudent_rejoindate.Text,
                doe = tf_renewstudent_outdate.Text,
                birth = tf_renewstudent_birthday.Text,
                academy_class = class_id
            };

            var result = await service.SetStudent(add);

            if (result.flag == true)
            {
                Util.ShowInDialog("알림", "원생재갱신 성공");
            }
            else
            {
                Util.ShowInDialog("알림", "원생재갱신 실패");

            }
        }

        private void tf_renewstudent_lecture_Click(object sender, EventArgs e)
        {
            SelectClassForm selectclassForm = new SelectClassForm(this, tf_renewstudent_lecture);
            selectclassForm.ShowDialog();
        }

        private void tf_renewstudent_lecture_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void tf_addstudent_lecture_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
