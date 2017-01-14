using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_mainpage_sex = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tab = new MaterialSkin.Controls.MaterialTabControl();
            this.mainpage = new System.Windows.Forms.TabPage();
            this.pb_mainpage_image = new System.Windows.Forms.PictureBox();
            this.lb_mainpage_birthday = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_lecture = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_outdate = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_rejoindate = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_join = new MaterialSkin.Controls.MaterialLabel();
            this.rb_mainpage_ban = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tf_mainpage_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_mainpage_shoolclass = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_grade = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_school = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_address = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_phone = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mainpage_id = new MaterialSkin.Controls.MaterialLabel();
            this.addstudentpage = new System.Windows.Forms.TabPage();
            this.lb_addstudent_searchimage = new MaterialSkin.Controls.MaterialLabel();
            this.tf_addstudent_joindate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_birthday = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_lecture = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_outdate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_schoolclass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_grade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_schoolname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_rejoindate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_addstudent_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rb_addstudent_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb_addstudent_sex = new MaterialSkin.Controls.MaterialLabel();
            this.pb_addstudent_image = new System.Windows.Forms.PictureBox();
            this.renewstudentpage = new System.Windows.Forms.TabPage();
            this.pb_renewstudent_image = new System.Windows.Forms.PictureBox();
            this.tf_renewstudent_birthday = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_lecture = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_outdate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_schoolclass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_grade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_schoolName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_rejoindate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_joindate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rb_renewstudent_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tf_renewstudent_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_renewstudent_sex = new MaterialSkin.Controls.MaterialLabel();
            this.checkpage = new System.Windows.Forms.TabPage();
            this.lv_attend_list = new MaterialSkin.Controls.MaterialListView();
            this.attendstudent_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attendstudent_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rb_attend_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Tab.SuspendLayout();
            this.mainpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainpage_image)).BeginInit();
            this.addstudentpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addstudent_image)).BeginInit();
            this.renewstudentpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_renewstudent_image)).BeginInit();
            this.checkpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_mainpage_sex
            // 
            this.lb_mainpage_sex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mainpage_sex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_sex.Depth = 0;
            this.lb_mainpage_sex.Location = new System.Drawing.Point(0, 438);
            this.lb_mainpage_sex.Margin = new System.Windows.Forms.Padding(0);
            this.lb_mainpage_sex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_sex.Name = "lb_mainpage_sex";
            this.lb_mainpage_sex.Size = new System.Drawing.Size(833, 1);
            this.lb_mainpage_sex.TabIndex = 16;
            this.lb_mainpage_sex.Text = "materialDivider1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.Tab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 74);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(833, 55);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.mainpage);
            this.Tab.Controls.Add(this.addstudentpage);
            this.Tab.Controls.Add(this.renewstudentpage);
            this.Tab.Controls.Add(this.checkpage);
            this.Tab.Depth = 0;
            this.Tab.Location = new System.Drawing.Point(18, 128);
            this.Tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(787, 295);
            this.Tab.TabIndex = 18;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // mainpage
            // 
            this.mainpage.BackColor = System.Drawing.Color.White;
            this.mainpage.Controls.Add(this.pb_mainpage_image);
            this.mainpage.Controls.Add(this.lb_mainpage_birthday);
            this.mainpage.Controls.Add(this.lb_mainpage_lecture);
            this.mainpage.Controls.Add(this.lb_mainpage_outdate);
            this.mainpage.Controls.Add(this.lb_mainpage_rejoindate);
            this.mainpage.Controls.Add(this.lb_mainpage_join);
            this.mainpage.Controls.Add(this.rb_mainpage_ban);
            this.mainpage.Controls.Add(this.tf_mainpage_search);
            this.mainpage.Controls.Add(this.lb_mainpage_shoolclass);
            this.mainpage.Controls.Add(this.lb_mainpage_grade);
            this.mainpage.Controls.Add(this.lb_mainpage_school);
            this.mainpage.Controls.Add(this.lb_mainpage_address);
            this.mainpage.Controls.Add(this.lb_mainpage_phone);
            this.mainpage.Controls.Add(this.lb_mainpage_name);
            this.mainpage.Controls.Add(this.materialLabel1);
            this.mainpage.Controls.Add(this.lb_mainpage_id);
            this.mainpage.Location = new System.Drawing.Point(4, 25);
            this.mainpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainpage.Name = "mainpage";
            this.mainpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainpage.Size = new System.Drawing.Size(779, 266);
            this.mainpage.TabIndex = 0;
            this.mainpage.Text = "메인화면";
            // 
            // pb_mainpage_image
            // 
            this.pb_mainpage_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_mainpage_image.Location = new System.Drawing.Point(7, 8);
            this.pb_mainpage_image.Name = "pb_mainpage_image";
            this.pb_mainpage_image.Size = new System.Drawing.Size(126, 138);
            this.pb_mainpage_image.TabIndex = 17;
            this.pb_mainpage_image.TabStop = false;
            // 
            // lb_mainpage_birthday
            // 
            this.lb_mainpage_birthday.AutoSize = true;
            this.lb_mainpage_birthday.Depth = 0;
            this.lb_mainpage_birthday.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_birthday.Location = new System.Drawing.Point(451, 130);
            this.lb_mainpage_birthday.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_birthday.Name = "lb_mainpage_birthday";
            this.lb_mainpage_birthday.Size = new System.Drawing.Size(40, 24);
            this.lb_mainpage_birthday.TabIndex = 16;
            this.lb_mainpage_birthday.Text = "생일";
            // 
            // lb_mainpage_lecture
            // 
            this.lb_mainpage_lecture.AutoSize = true;
            this.lb_mainpage_lecture.Depth = 0;
            this.lb_mainpage_lecture.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_lecture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_lecture.Location = new System.Drawing.Point(451, 106);
            this.lb_mainpage_lecture.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_lecture.Name = "lb_mainpage_lecture";
            this.lb_mainpage_lecture.Size = new System.Drawing.Size(70, 24);
            this.lb_mainpage_lecture.TabIndex = 15;
            this.lb_mainpage_lecture.Text = "수강강좌";
            // 
            // lb_mainpage_outdate
            // 
            this.lb_mainpage_outdate.AutoSize = true;
            this.lb_mainpage_outdate.Depth = 0;
            this.lb_mainpage_outdate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_outdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_outdate.Location = new System.Drawing.Point(451, 73);
            this.lb_mainpage_outdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_outdate.Name = "lb_mainpage_outdate";
            this.lb_mainpage_outdate.Size = new System.Drawing.Size(70, 24);
            this.lb_mainpage_outdate.TabIndex = 14;
            this.lb_mainpage_outdate.Text = "퇴소일자";
            // 
            // lb_mainpage_rejoindate
            // 
            this.lb_mainpage_rejoindate.AutoSize = true;
            this.lb_mainpage_rejoindate.Depth = 0;
            this.lb_mainpage_rejoindate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_rejoindate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_rejoindate.Location = new System.Drawing.Point(451, 40);
            this.lb_mainpage_rejoindate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_rejoindate.Name = "lb_mainpage_rejoindate";
            this.lb_mainpage_rejoindate.Size = new System.Drawing.Size(85, 24);
            this.lb_mainpage_rejoindate.TabIndex = 13;
            this.lb_mainpage_rejoindate.Text = "재입학일자";
            // 
            // lb_mainpage_join
            // 
            this.lb_mainpage_join.AutoSize = true;
            this.lb_mainpage_join.Depth = 0;
            this.lb_mainpage_join.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_join.Location = new System.Drawing.Point(451, 8);
            this.lb_mainpage_join.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_join.Name = "lb_mainpage_join";
            this.lb_mainpage_join.Size = new System.Drawing.Size(70, 24);
            this.lb_mainpage_join.TabIndex = 12;
            this.lb_mainpage_join.Text = "입학일자";
            // 
            // rb_mainpage_ban
            // 
            this.rb_mainpage_ban.AutoSize = true;
            this.rb_mainpage_ban.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_mainpage_ban.Depth = 0;
            this.rb_mainpage_ban.Icon = null;
            this.rb_mainpage_ban.Location = new System.Drawing.Point(675, 223);
            this.rb_mainpage_ban.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_mainpage_ban.Name = "rb_mainpage_ban";
            this.rb_mainpage_ban.Primary = true;
            this.rb_mainpage_ban.Size = new System.Drawing.Size(98, 36);
            this.rb_mainpage_ban.TabIndex = 11;
            this.rb_mainpage_ban.Text = "퇴소처리";
            this.rb_mainpage_ban.UseVisualStyleBackColor = true;
            // 
            // tf_mainpage_search
            // 
            this.tf_mainpage_search.Depth = 0;
            this.tf_mainpage_search.Hint = "검색";
            this.tf_mainpage_search.Location = new System.Drawing.Point(11, 223);
            this.tf_mainpage_search.MaxLength = 32767;
            this.tf_mainpage_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_mainpage_search.Name = "tf_mainpage_search";
            this.tf_mainpage_search.PasswordChar = '\0';
            this.tf_mainpage_search.SelectedText = "";
            this.tf_mainpage_search.SelectionLength = 0;
            this.tf_mainpage_search.SelectionStart = 0;
            this.tf_mainpage_search.Size = new System.Drawing.Size(610, 28);
            this.tf_mainpage_search.TabIndex = 10;
            this.tf_mainpage_search.TabStop = false;
            this.tf_mainpage_search.UseSystemPasswordChar = false;
            // 
            // lb_mainpage_shoolclass
            // 
            this.lb_mainpage_shoolclass.AutoSize = true;
            this.lb_mainpage_shoolclass.Depth = 0;
            this.lb_mainpage_shoolclass.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_shoolclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_shoolclass.Location = new System.Drawing.Point(143, 122);
            this.lb_mainpage_shoolclass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_shoolclass.Name = "lb_mainpage_shoolclass";
            this.lb_mainpage_shoolclass.Size = new System.Drawing.Size(55, 24);
            this.lb_mainpage_shoolclass.TabIndex = 9;
            this.lb_mainpage_shoolclass.Text = "class";
            // 
            // lb_mainpage_grade
            // 
            this.lb_mainpage_grade.AutoSize = true;
            this.lb_mainpage_grade.Depth = 0;
            this.lb_mainpage_grade.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_grade.Location = new System.Drawing.Point(144, 92);
            this.lb_mainpage_grade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_grade.Name = "lb_mainpage_grade";
            this.lb_mainpage_grade.Size = new System.Drawing.Size(58, 24);
            this.lb_mainpage_grade.TabIndex = 8;
            this.lb_mainpage_grade.Text = "grade";
            // 
            // lb_mainpage_school
            // 
            this.lb_mainpage_school.AutoSize = true;
            this.lb_mainpage_school.Depth = 0;
            this.lb_mainpage_school.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_school.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_school.Location = new System.Drawing.Point(139, 64);
            this.lb_mainpage_school.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_school.Name = "lb_mainpage_school";
            this.lb_mainpage_school.Size = new System.Drawing.Size(114, 24);
            this.lb_mainpage_school.TabIndex = 7;
            this.lb_mainpage_school.Text = "schoolname";
            // 
            // lb_mainpage_address
            // 
            this.lb_mainpage_address.AutoSize = true;
            this.lb_mainpage_address.Depth = 0;
            this.lb_mainpage_address.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_address.Location = new System.Drawing.Point(140, 40);
            this.lb_mainpage_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_address.Name = "lb_mainpage_address";
            this.lb_mainpage_address.Size = new System.Drawing.Size(78, 24);
            this.lb_mainpage_address.TabIndex = 6;
            this.lb_mainpage_address.Text = "address";
            // 
            // lb_mainpage_phone
            // 
            this.lb_mainpage_phone.AutoSize = true;
            this.lb_mainpage_phone.Depth = 0;
            this.lb_mainpage_phone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_phone.Location = new System.Drawing.Point(140, 8);
            this.lb_mainpage_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_phone.Name = "lb_mainpage_phone";
            this.lb_mainpage_phone.Size = new System.Drawing.Size(62, 24);
            this.lb_mainpage_phone.TabIndex = 5;
            this.lb_mainpage_phone.Text = "phone";
            // 
            // lb_mainpage_name
            // 
            this.lb_mainpage_name.AutoSize = true;
            this.lb_mainpage_name.Depth = 0;
            this.lb_mainpage_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_name.Location = new System.Drawing.Point(7, 151);
            this.lb_mainpage_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_name.Name = "lb_mainpage_name";
            this.lb_mainpage_name.Size = new System.Drawing.Size(40, 24);
            this.lb_mainpage_name.TabIndex = 4;
            this.lb_mainpage_name.Text = "이름";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(108, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(27, 26);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "남";
            // 
            // lb_mainpage_id
            // 
            this.lb_mainpage_id.AutoSize = true;
            this.lb_mainpage_id.Depth = 0;
            this.lb_mainpage_id.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_id.Location = new System.Drawing.Point(7, 184);
            this.lb_mainpage_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_id.Name = "lb_mainpage_id";
            this.lb_mainpage_id.Size = new System.Drawing.Size(70, 24);
            this.lb_mainpage_id.TabIndex = 2;
            this.lb_mainpage_id.Text = "학생번호";
            // 
            // addstudentpage
            // 
            this.addstudentpage.BackColor = System.Drawing.Color.White;
            this.addstudentpage.Controls.Add(this.lb_addstudent_searchimage);
            this.addstudentpage.Controls.Add(this.tf_addstudent_joindate);
            this.addstudentpage.Controls.Add(this.tf_addstudent_birthday);
            this.addstudentpage.Controls.Add(this.tf_addstudent_lecture);
            this.addstudentpage.Controls.Add(this.tf_addstudent_outdate);
            this.addstudentpage.Controls.Add(this.tf_addstudent_schoolclass);
            this.addstudentpage.Controls.Add(this.tf_addstudent_grade);
            this.addstudentpage.Controls.Add(this.tf_addstudent_schoolname);
            this.addstudentpage.Controls.Add(this.tf_addstudent_address);
            this.addstudentpage.Controls.Add(this.tf_addstudent_rejoindate);
            this.addstudentpage.Controls.Add(this.tf_addstudent_phone);
            this.addstudentpage.Controls.Add(this.tf_addstudent_name);
            this.addstudentpage.Controls.Add(this.rb_addstudent_submit);
            this.addstudentpage.Controls.Add(this.lb_addstudent_sex);
            this.addstudentpage.Controls.Add(this.pb_addstudent_image);
            this.addstudentpage.Location = new System.Drawing.Point(4, 25);
            this.addstudentpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addstudentpage.Name = "addstudentpage";
            this.addstudentpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addstudentpage.Size = new System.Drawing.Size(779, 266);
            this.addstudentpage.TabIndex = 1;
            this.addstudentpage.Text = "원생추가";
            // 
            // lb_addstudent_searchimage
            // 
            this.lb_addstudent_searchimage.AutoSize = true;
            this.lb_addstudent_searchimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_addstudent_searchimage.Depth = 0;
            this.lb_addstudent_searchimage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_addstudent_searchimage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_addstudent_searchimage.Location = new System.Drawing.Point(6, 9);
            this.lb_addstudent_searchimage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_addstudent_searchimage.Name = "lb_addstudent_searchimage";
            this.lb_addstudent_searchimage.Size = new System.Drawing.Size(27, 26);
            this.lb_addstudent_searchimage.TabIndex = 17;
            this.lb_addstudent_searchimage.Text = "...";
            this.lb_addstudent_searchimage.Click += new System.EventHandler(this.lb_addstudent_searchimage_Click);
            // 
            // tf_addstudent_joindate
            // 
            this.tf_addstudent_joindate.Depth = 0;
            this.tf_addstudent_joindate.Hint = "입학일자";
            this.tf_addstudent_joindate.Location = new System.Drawing.Point(421, 8);
            this.tf_addstudent_joindate.MaxLength = 32767;
            this.tf_addstudent_joindate.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_joindate.Name = "tf_addstudent_joindate";
            this.tf_addstudent_joindate.PasswordChar = '\0';
            this.tf_addstudent_joindate.SelectedText = "";
            this.tf_addstudent_joindate.SelectionLength = 0;
            this.tf_addstudent_joindate.SelectionStart = 0;
            this.tf_addstudent_joindate.Size = new System.Drawing.Size(352, 28);
            this.tf_addstudent_joindate.TabIndex = 15;
            this.tf_addstudent_joindate.TabStop = false;
            this.tf_addstudent_joindate.UseSystemPasswordChar = false;
            this.tf_addstudent_joindate.Click += new System.EventHandler(this.tf_addstudent_joindate_Click);
            this.tf_addstudent_joindate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_addstudent_joindate_KeyDown);
            // 
            // tf_addstudent_birthday
            // 
            this.tf_addstudent_birthday.Depth = 0;
            this.tf_addstudent_birthday.Hint = "생일";
            this.tf_addstudent_birthday.Location = new System.Drawing.Point(421, 146);
            this.tf_addstudent_birthday.MaxLength = 32767;
            this.tf_addstudent_birthday.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_birthday.Name = "tf_addstudent_birthday";
            this.tf_addstudent_birthday.PasswordChar = '\0';
            this.tf_addstudent_birthday.SelectedText = "";
            this.tf_addstudent_birthday.SelectionLength = 0;
            this.tf_addstudent_birthday.SelectionStart = 0;
            this.tf_addstudent_birthday.Size = new System.Drawing.Size(352, 28);
            this.tf_addstudent_birthday.TabIndex = 14;
            this.tf_addstudent_birthday.TabStop = false;
            this.tf_addstudent_birthday.UseSystemPasswordChar = false;
            this.tf_addstudent_birthday.Click += new System.EventHandler(this.tf_addstudent_birthday_Click);
            this.tf_addstudent_birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_addstudent_birthday_KeyDown);
            // 
            // tf_addstudent_lecture
            // 
            this.tf_addstudent_lecture.Depth = 0;
            this.tf_addstudent_lecture.Hint = "강좌";
            this.tf_addstudent_lecture.Location = new System.Drawing.Point(421, 111);
            this.tf_addstudent_lecture.MaxLength = 32767;
            this.tf_addstudent_lecture.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_lecture.Name = "tf_addstudent_lecture";
            this.tf_addstudent_lecture.PasswordChar = '\0';
            this.tf_addstudent_lecture.SelectedText = "";
            this.tf_addstudent_lecture.SelectionLength = 0;
            this.tf_addstudent_lecture.SelectionStart = 0;
            this.tf_addstudent_lecture.Size = new System.Drawing.Size(352, 28);
            this.tf_addstudent_lecture.TabIndex = 13;
            this.tf_addstudent_lecture.TabStop = false;
            this.tf_addstudent_lecture.UseSystemPasswordChar = false;
            // 
            // tf_addstudent_outdate
            // 
            this.tf_addstudent_outdate.Depth = 0;
            this.tf_addstudent_outdate.Hint = "퇴소일자";
            this.tf_addstudent_outdate.Location = new System.Drawing.Point(421, 76);
            this.tf_addstudent_outdate.MaxLength = 32767;
            this.tf_addstudent_outdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_outdate.Name = "tf_addstudent_outdate";
            this.tf_addstudent_outdate.PasswordChar = '\0';
            this.tf_addstudent_outdate.SelectedText = "";
            this.tf_addstudent_outdate.SelectionLength = 0;
            this.tf_addstudent_outdate.SelectionStart = 0;
            this.tf_addstudent_outdate.Size = new System.Drawing.Size(352, 28);
            this.tf_addstudent_outdate.TabIndex = 12;
            this.tf_addstudent_outdate.TabStop = false;
            this.tf_addstudent_outdate.UseSystemPasswordChar = false;
            this.tf_addstudent_outdate.Click += new System.EventHandler(this.tf_addstudent_outdate_Click);
            this.tf_addstudent_outdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_addstudent_outdate_KeyDown);
            // 
            // tf_addstudent_schoolclass
            // 
            this.tf_addstudent_schoolclass.Depth = 0;
            this.tf_addstudent_schoolclass.Hint = "학교반";
            this.tf_addstudent_schoolclass.Location = new System.Drawing.Point(145, 146);
            this.tf_addstudent_schoolclass.MaxLength = 32767;
            this.tf_addstudent_schoolclass.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_schoolclass.Name = "tf_addstudent_schoolclass";
            this.tf_addstudent_schoolclass.PasswordChar = '\0';
            this.tf_addstudent_schoolclass.SelectedText = "";
            this.tf_addstudent_schoolclass.SelectionLength = 0;
            this.tf_addstudent_schoolclass.SelectionStart = 0;
            this.tf_addstudent_schoolclass.Size = new System.Drawing.Size(269, 28);
            this.tf_addstudent_schoolclass.TabIndex = 11;
            this.tf_addstudent_schoolclass.TabStop = false;
            this.tf_addstudent_schoolclass.UseSystemPasswordChar = false;
            // 
            // tf_addstudent_grade
            // 
            this.tf_addstudent_grade.Depth = 0;
            this.tf_addstudent_grade.Hint = "학년";
            this.tf_addstudent_grade.Location = new System.Drawing.Point(146, 111);
            this.tf_addstudent_grade.MaxLength = 32767;
            this.tf_addstudent_grade.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_grade.Name = "tf_addstudent_grade";
            this.tf_addstudent_grade.PasswordChar = '\0';
            this.tf_addstudent_grade.SelectedText = "";
            this.tf_addstudent_grade.SelectionLength = 0;
            this.tf_addstudent_grade.SelectionStart = 0;
            this.tf_addstudent_grade.Size = new System.Drawing.Size(268, 28);
            this.tf_addstudent_grade.TabIndex = 10;
            this.tf_addstudent_grade.TabStop = false;
            this.tf_addstudent_grade.UseSystemPasswordChar = false;
            // 
            // tf_addstudent_schoolname
            // 
            this.tf_addstudent_schoolname.Depth = 0;
            this.tf_addstudent_schoolname.Hint = "학교이름";
            this.tf_addstudent_schoolname.Location = new System.Drawing.Point(146, 76);
            this.tf_addstudent_schoolname.MaxLength = 32767;
            this.tf_addstudent_schoolname.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_schoolname.Name = "tf_addstudent_schoolname";
            this.tf_addstudent_schoolname.PasswordChar = '\0';
            this.tf_addstudent_schoolname.SelectedText = "";
            this.tf_addstudent_schoolname.SelectionLength = 0;
            this.tf_addstudent_schoolname.SelectionStart = 0;
            this.tf_addstudent_schoolname.Size = new System.Drawing.Size(268, 28);
            this.tf_addstudent_schoolname.TabIndex = 9;
            this.tf_addstudent_schoolname.TabStop = false;
            this.tf_addstudent_schoolname.UseSystemPasswordChar = false;
            // 
            // tf_addstudent_address
            // 
            this.tf_addstudent_address.Depth = 0;
            this.tf_addstudent_address.Hint = "주소";
            this.tf_addstudent_address.Location = new System.Drawing.Point(145, 41);
            this.tf_addstudent_address.MaxLength = 32767;
            this.tf_addstudent_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_address.Name = "tf_addstudent_address";
            this.tf_addstudent_address.PasswordChar = '\0';
            this.tf_addstudent_address.SelectedText = "";
            this.tf_addstudent_address.SelectionLength = 0;
            this.tf_addstudent_address.SelectionStart = 0;
            this.tf_addstudent_address.Size = new System.Drawing.Size(269, 28);
            this.tf_addstudent_address.TabIndex = 8;
            this.tf_addstudent_address.TabStop = false;
            this.tf_addstudent_address.UseSystemPasswordChar = false;
            // 
            // tf_addstudent_rejoindate
            // 
            this.tf_addstudent_rejoindate.Depth = 0;
            this.tf_addstudent_rejoindate.Hint = "재입학일자";
            this.tf_addstudent_rejoindate.Location = new System.Drawing.Point(420, 41);
            this.tf_addstudent_rejoindate.MaxLength = 32767;
            this.tf_addstudent_rejoindate.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_rejoindate.Name = "tf_addstudent_rejoindate";
            this.tf_addstudent_rejoindate.PasswordChar = '\0';
            this.tf_addstudent_rejoindate.SelectedText = "";
            this.tf_addstudent_rejoindate.SelectionLength = 0;
            this.tf_addstudent_rejoindate.SelectionStart = 0;
            this.tf_addstudent_rejoindate.Size = new System.Drawing.Size(353, 28);
            this.tf_addstudent_rejoindate.TabIndex = 7;
            this.tf_addstudent_rejoindate.TabStop = false;
            this.tf_addstudent_rejoindate.UseSystemPasswordChar = false;
            this.tf_addstudent_rejoindate.Click += new System.EventHandler(this.tf_addstudent_rejoindate_Click);
            this.tf_addstudent_rejoindate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_addstudent_rejoindate_KeyDown);
            // 
            // tf_addstudent_phone
            // 
            this.tf_addstudent_phone.Depth = 0;
            this.tf_addstudent_phone.Hint = "전화번호";
            this.tf_addstudent_phone.Location = new System.Drawing.Point(145, 7);
            this.tf_addstudent_phone.MaxLength = 32767;
            this.tf_addstudent_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_phone.Name = "tf_addstudent_phone";
            this.tf_addstudent_phone.PasswordChar = '\0';
            this.tf_addstudent_phone.SelectedText = "";
            this.tf_addstudent_phone.SelectionLength = 0;
            this.tf_addstudent_phone.SelectionStart = 0;
            this.tf_addstudent_phone.Size = new System.Drawing.Size(269, 28);
            this.tf_addstudent_phone.TabIndex = 5;
            this.tf_addstudent_phone.TabStop = false;
            this.tf_addstudent_phone.UseSystemPasswordChar = false;
            // 
            // tf_addstudent_name
            // 
            this.tf_addstudent_name.Depth = 0;
            this.tf_addstudent_name.Hint = "이름";
            this.tf_addstudent_name.Location = new System.Drawing.Point(6, 160);
            this.tf_addstudent_name.MaxLength = 32767;
            this.tf_addstudent_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_addstudent_name.Name = "tf_addstudent_name";
            this.tf_addstudent_name.PasswordChar = '\0';
            this.tf_addstudent_name.SelectedText = "";
            this.tf_addstudent_name.SelectionLength = 0;
            this.tf_addstudent_name.SelectionStart = 0;
            this.tf_addstudent_name.Size = new System.Drawing.Size(102, 28);
            this.tf_addstudent_name.TabIndex = 4;
            this.tf_addstudent_name.TabStop = false;
            this.tf_addstudent_name.UseSystemPasswordChar = false;
            // 
            // rb_addstudent_submit
            // 
            this.rb_addstudent_submit.AutoSize = true;
            this.rb_addstudent_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_addstudent_submit.Depth = 0;
            this.rb_addstudent_submit.Icon = null;
            this.rb_addstudent_submit.Location = new System.Drawing.Point(675, 223);
            this.rb_addstudent_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_addstudent_submit.Name = "rb_addstudent_submit";
            this.rb_addstudent_submit.Primary = true;
            this.rb_addstudent_submit.Size = new System.Drawing.Size(98, 36);
            this.rb_addstudent_submit.TabIndex = 3;
            this.rb_addstudent_submit.Text = "원생추가";
            this.rb_addstudent_submit.UseVisualStyleBackColor = true;
            this.rb_addstudent_submit.Click += new System.EventHandler(this.rb_addstudent_submit_Click);
            // 
            // lb_addstudent_sex
            // 
            this.lb_addstudent_sex.AutoSize = true;
            this.lb_addstudent_sex.BackColor = System.Drawing.Color.White;
            this.lb_addstudent_sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_addstudent_sex.Depth = 0;
            this.lb_addstudent_sex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_addstudent_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_addstudent_sex.Location = new System.Drawing.Point(112, 160);
            this.lb_addstudent_sex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_addstudent_sex.Name = "lb_addstudent_sex";
            this.lb_addstudent_sex.Size = new System.Drawing.Size(27, 26);
            this.lb_addstudent_sex.TabIndex = 0;
            this.lb_addstudent_sex.Text = "남";
            this.lb_addstudent_sex.Click += new System.EventHandler(this.lb_addstudent_sex_Click);
            // 
            // pb_addstudent_image
            // 
            this.pb_addstudent_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_addstudent_image.Location = new System.Drawing.Point(7, 8);
            this.pb_addstudent_image.Name = "pb_addstudent_image";
            this.pb_addstudent_image.Size = new System.Drawing.Size(133, 149);
            this.pb_addstudent_image.TabIndex = 16;
            this.pb_addstudent_image.TabStop = false;
            // 
            // renewstudentpage
            // 
            this.renewstudentpage.BackColor = System.Drawing.Color.White;
            this.renewstudentpage.Controls.Add(this.pb_renewstudent_image);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_birthday);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_lecture);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_outdate);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_schoolclass);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_grade);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_schoolName);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_address);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_rejoindate);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_joindate);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_phone);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_name);
            this.renewstudentpage.Controls.Add(this.rb_renewstudent_submit);
            this.renewstudentpage.Controls.Add(this.tf_renewstudent_search);
            this.renewstudentpage.Controls.Add(this.lb_renewstudent_sex);
            this.renewstudentpage.Location = new System.Drawing.Point(4, 25);
            this.renewstudentpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.renewstudentpage.Name = "renewstudentpage";
            this.renewstudentpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.renewstudentpage.Size = new System.Drawing.Size(779, 266);
            this.renewstudentpage.TabIndex = 2;
            this.renewstudentpage.Text = "원생재갱신";
            // 
            // pb_renewstudent_image
            // 
            this.pb_renewstudent_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_renewstudent_image.Location = new System.Drawing.Point(7, 8);
            this.pb_renewstudent_image.Name = "pb_renewstudent_image";
            this.pb_renewstudent_image.Size = new System.Drawing.Size(120, 141);
            this.pb_renewstudent_image.TabIndex = 29;
            this.pb_renewstudent_image.TabStop = false;
            // 
            // tf_renewstudent_birthday
            // 
            this.tf_renewstudent_birthday.Depth = 0;
            this.tf_renewstudent_birthday.Hint = "생일";
            this.tf_renewstudent_birthday.Location = new System.Drawing.Point(421, 154);
            this.tf_renewstudent_birthday.MaxLength = 32767;
            this.tf_renewstudent_birthday.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_birthday.Name = "tf_renewstudent_birthday";
            this.tf_renewstudent_birthday.PasswordChar = '\0';
            this.tf_renewstudent_birthday.SelectedText = "";
            this.tf_renewstudent_birthday.SelectionLength = 0;
            this.tf_renewstudent_birthday.SelectionStart = 0;
            this.tf_renewstudent_birthday.Size = new System.Drawing.Size(352, 28);
            this.tf_renewstudent_birthday.TabIndex = 28;
            this.tf_renewstudent_birthday.TabStop = false;
            this.tf_renewstudent_birthday.UseSystemPasswordChar = false;
            this.tf_renewstudent_birthday.Click += new System.EventHandler(this.tf_renewstudent_birthday_Click);
            this.tf_renewstudent_birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_renewstudent_birthday_KeyDown);
            // 
            // tf_renewstudent_lecture
            // 
            this.tf_renewstudent_lecture.Depth = 0;
            this.tf_renewstudent_lecture.Hint = "강좌";
            this.tf_renewstudent_lecture.Location = new System.Drawing.Point(421, 119);
            this.tf_renewstudent_lecture.MaxLength = 32767;
            this.tf_renewstudent_lecture.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_lecture.Name = "tf_renewstudent_lecture";
            this.tf_renewstudent_lecture.PasswordChar = '\0';
            this.tf_renewstudent_lecture.SelectedText = "";
            this.tf_renewstudent_lecture.SelectionLength = 0;
            this.tf_renewstudent_lecture.SelectionStart = 0;
            this.tf_renewstudent_lecture.Size = new System.Drawing.Size(352, 28);
            this.tf_renewstudent_lecture.TabIndex = 27;
            this.tf_renewstudent_lecture.TabStop = false;
            this.tf_renewstudent_lecture.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_outdate
            // 
            this.tf_renewstudent_outdate.Depth = 0;
            this.tf_renewstudent_outdate.Hint = "퇴소일자";
            this.tf_renewstudent_outdate.Location = new System.Drawing.Point(421, 84);
            this.tf_renewstudent_outdate.MaxLength = 32767;
            this.tf_renewstudent_outdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_outdate.Name = "tf_renewstudent_outdate";
            this.tf_renewstudent_outdate.PasswordChar = '\0';
            this.tf_renewstudent_outdate.SelectedText = "";
            this.tf_renewstudent_outdate.SelectionLength = 0;
            this.tf_renewstudent_outdate.SelectionStart = 0;
            this.tf_renewstudent_outdate.Size = new System.Drawing.Size(352, 28);
            this.tf_renewstudent_outdate.TabIndex = 26;
            this.tf_renewstudent_outdate.TabStop = false;
            this.tf_renewstudent_outdate.UseSystemPasswordChar = false;
            this.tf_renewstudent_outdate.Click += new System.EventHandler(this.tf_renewstudent_outdate_Click);
            this.tf_renewstudent_outdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_renewstudent_outdate_KeyDown);
            // 
            // tf_renewstudent_schoolclass
            // 
            this.tf_renewstudent_schoolclass.Depth = 0;
            this.tf_renewstudent_schoolclass.Hint = "학교반";
            this.tf_renewstudent_schoolclass.Location = new System.Drawing.Point(145, 154);
            this.tf_renewstudent_schoolclass.MaxLength = 32767;
            this.tf_renewstudent_schoolclass.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_schoolclass.Name = "tf_renewstudent_schoolclass";
            this.tf_renewstudent_schoolclass.PasswordChar = '\0';
            this.tf_renewstudent_schoolclass.SelectedText = "";
            this.tf_renewstudent_schoolclass.SelectionLength = 0;
            this.tf_renewstudent_schoolclass.SelectionStart = 0;
            this.tf_renewstudent_schoolclass.Size = new System.Drawing.Size(269, 28);
            this.tf_renewstudent_schoolclass.TabIndex = 25;
            this.tf_renewstudent_schoolclass.TabStop = false;
            this.tf_renewstudent_schoolclass.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_grade
            // 
            this.tf_renewstudent_grade.Depth = 0;
            this.tf_renewstudent_grade.Hint = "학년";
            this.tf_renewstudent_grade.Location = new System.Drawing.Point(146, 119);
            this.tf_renewstudent_grade.MaxLength = 32767;
            this.tf_renewstudent_grade.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_grade.Name = "tf_renewstudent_grade";
            this.tf_renewstudent_grade.PasswordChar = '\0';
            this.tf_renewstudent_grade.SelectedText = "";
            this.tf_renewstudent_grade.SelectionLength = 0;
            this.tf_renewstudent_grade.SelectionStart = 0;
            this.tf_renewstudent_grade.Size = new System.Drawing.Size(268, 28);
            this.tf_renewstudent_grade.TabIndex = 24;
            this.tf_renewstudent_grade.TabStop = false;
            this.tf_renewstudent_grade.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_schoolName
            // 
            this.tf_renewstudent_schoolName.Depth = 0;
            this.tf_renewstudent_schoolName.Hint = "학교이름";
            this.tf_renewstudent_schoolName.Location = new System.Drawing.Point(146, 84);
            this.tf_renewstudent_schoolName.MaxLength = 32767;
            this.tf_renewstudent_schoolName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_schoolName.Name = "tf_renewstudent_schoolName";
            this.tf_renewstudent_schoolName.PasswordChar = '\0';
            this.tf_renewstudent_schoolName.SelectedText = "";
            this.tf_renewstudent_schoolName.SelectionLength = 0;
            this.tf_renewstudent_schoolName.SelectionStart = 0;
            this.tf_renewstudent_schoolName.Size = new System.Drawing.Size(268, 28);
            this.tf_renewstudent_schoolName.TabIndex = 23;
            this.tf_renewstudent_schoolName.TabStop = false;
            this.tf_renewstudent_schoolName.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_address
            // 
            this.tf_renewstudent_address.Depth = 0;
            this.tf_renewstudent_address.Hint = "주소";
            this.tf_renewstudent_address.Location = new System.Drawing.Point(145, 49);
            this.tf_renewstudent_address.MaxLength = 32767;
            this.tf_renewstudent_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_address.Name = "tf_renewstudent_address";
            this.tf_renewstudent_address.PasswordChar = '\0';
            this.tf_renewstudent_address.SelectedText = "";
            this.tf_renewstudent_address.SelectionLength = 0;
            this.tf_renewstudent_address.SelectionStart = 0;
            this.tf_renewstudent_address.Size = new System.Drawing.Size(269, 28);
            this.tf_renewstudent_address.TabIndex = 22;
            this.tf_renewstudent_address.TabStop = false;
            this.tf_renewstudent_address.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_rejoindate
            // 
            this.tf_renewstudent_rejoindate.Depth = 0;
            this.tf_renewstudent_rejoindate.Hint = "재입학일자";
            this.tf_renewstudent_rejoindate.Location = new System.Drawing.Point(420, 49);
            this.tf_renewstudent_rejoindate.MaxLength = 32767;
            this.tf_renewstudent_rejoindate.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_rejoindate.Name = "tf_renewstudent_rejoindate";
            this.tf_renewstudent_rejoindate.PasswordChar = '\0';
            this.tf_renewstudent_rejoindate.SelectedText = "";
            this.tf_renewstudent_rejoindate.SelectionLength = 0;
            this.tf_renewstudent_rejoindate.SelectionStart = 0;
            this.tf_renewstudent_rejoindate.Size = new System.Drawing.Size(353, 28);
            this.tf_renewstudent_rejoindate.TabIndex = 21;
            this.tf_renewstudent_rejoindate.TabStop = false;
            this.tf_renewstudent_rejoindate.UseSystemPasswordChar = false;
            this.tf_renewstudent_rejoindate.Click += new System.EventHandler(this.tf_renewstudent_rejoindate_Click);
            this.tf_renewstudent_rejoindate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_renewstudent_rejoindate_KeyDown);
            // 
            // tf_renewstudent_joindate
            // 
            this.tf_renewstudent_joindate.Depth = 0;
            this.tf_renewstudent_joindate.Hint = "입학일자";
            this.tf_renewstudent_joindate.Location = new System.Drawing.Point(420, 15);
            this.tf_renewstudent_joindate.MaxLength = 32767;
            this.tf_renewstudent_joindate.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_joindate.Name = "tf_renewstudent_joindate";
            this.tf_renewstudent_joindate.PasswordChar = '\0';
            this.tf_renewstudent_joindate.SelectedText = "";
            this.tf_renewstudent_joindate.SelectionLength = 0;
            this.tf_renewstudent_joindate.SelectionStart = 0;
            this.tf_renewstudent_joindate.Size = new System.Drawing.Size(353, 28);
            this.tf_renewstudent_joindate.TabIndex = 20;
            this.tf_renewstudent_joindate.TabStop = false;
            this.tf_renewstudent_joindate.UseSystemPasswordChar = false;
            this.tf_renewstudent_joindate.Click += new System.EventHandler(this.tf_renewstudent_joindate_Click);
            this.tf_renewstudent_joindate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_renewstudent_joindate_KeyDown);
            // 
            // tf_renewstudent_phone
            // 
            this.tf_renewstudent_phone.Depth = 0;
            this.tf_renewstudent_phone.Hint = "전화번호";
            this.tf_renewstudent_phone.Location = new System.Drawing.Point(145, 15);
            this.tf_renewstudent_phone.MaxLength = 32767;
            this.tf_renewstudent_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_phone.Name = "tf_renewstudent_phone";
            this.tf_renewstudent_phone.PasswordChar = '\0';
            this.tf_renewstudent_phone.SelectedText = "";
            this.tf_renewstudent_phone.SelectionLength = 0;
            this.tf_renewstudent_phone.SelectionStart = 0;
            this.tf_renewstudent_phone.Size = new System.Drawing.Size(269, 28);
            this.tf_renewstudent_phone.TabIndex = 19;
            this.tf_renewstudent_phone.TabStop = false;
            this.tf_renewstudent_phone.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_name
            // 
            this.tf_renewstudent_name.Depth = 0;
            this.tf_renewstudent_name.Hint = "이름";
            this.tf_renewstudent_name.Location = new System.Drawing.Point(3, 152);
            this.tf_renewstudent_name.MaxLength = 32767;
            this.tf_renewstudent_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_name.Name = "tf_renewstudent_name";
            this.tf_renewstudent_name.PasswordChar = '\0';
            this.tf_renewstudent_name.SelectedText = "";
            this.tf_renewstudent_name.SelectionLength = 0;
            this.tf_renewstudent_name.SelectionStart = 0;
            this.tf_renewstudent_name.Size = new System.Drawing.Size(91, 28);
            this.tf_renewstudent_name.TabIndex = 5;
            this.tf_renewstudent_name.TabStop = false;
            this.tf_renewstudent_name.UseSystemPasswordChar = false;
            // 
            // rb_renewstudent_submit
            // 
            this.rb_renewstudent_submit.AutoSize = true;
            this.rb_renewstudent_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_renewstudent_submit.Depth = 0;
            this.rb_renewstudent_submit.Icon = null;
            this.rb_renewstudent_submit.Location = new System.Drawing.Point(652, 227);
            this.rb_renewstudent_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_renewstudent_submit.Name = "rb_renewstudent_submit";
            this.rb_renewstudent_submit.Primary = true;
            this.rb_renewstudent_submit.Size = new System.Drawing.Size(121, 36);
            this.rb_renewstudent_submit.TabIndex = 4;
            this.rb_renewstudent_submit.Text = "원생 재갱신";
            this.rb_renewstudent_submit.UseVisualStyleBackColor = true;
            // 
            // tf_renewstudent_search
            // 
            this.tf_renewstudent_search.Depth = 0;
            this.tf_renewstudent_search.Hint = "검색";
            this.tf_renewstudent_search.Location = new System.Drawing.Point(6, 231);
            this.tf_renewstudent_search.MaxLength = 32767;
            this.tf_renewstudent_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_search.Name = "tf_renewstudent_search";
            this.tf_renewstudent_search.PasswordChar = '\0';
            this.tf_renewstudent_search.SelectedText = "";
            this.tf_renewstudent_search.SelectionLength = 0;
            this.tf_renewstudent_search.SelectionStart = 0;
            this.tf_renewstudent_search.Size = new System.Drawing.Size(592, 28);
            this.tf_renewstudent_search.TabIndex = 3;
            this.tf_renewstudent_search.TabStop = false;
            this.tf_renewstudent_search.UseSystemPasswordChar = false;
            this.tf_renewstudent_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_renewstudent_search_KeyDown);
            // 
            // lb_renewstudent_sex
            // 
            this.lb_renewstudent_sex.AutoSize = true;
            this.lb_renewstudent_sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_renewstudent_sex.Depth = 0;
            this.lb_renewstudent_sex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_renewstudent_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_renewstudent_sex.Location = new System.Drawing.Point(100, 152);
            this.lb_renewstudent_sex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_renewstudent_sex.Name = "lb_renewstudent_sex";
            this.lb_renewstudent_sex.Size = new System.Drawing.Size(27, 26);
            this.lb_renewstudent_sex.TabIndex = 1;
            this.lb_renewstudent_sex.Text = "남";
            this.lb_renewstudent_sex.Click += new System.EventHandler(this.lb_renewstudent_sex_Click);
            // 
            // checkpage
            // 
            this.checkpage.Controls.Add(this.lv_attend_list);
            this.checkpage.Controls.Add(this.rb_attend_submit);
            this.checkpage.Location = new System.Drawing.Point(4, 25);
            this.checkpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkpage.Name = "checkpage";
            this.checkpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkpage.Size = new System.Drawing.Size(779, 266);
            this.checkpage.TabIndex = 3;
            this.checkpage.Text = "출석체크";
            this.checkpage.UseVisualStyleBackColor = true;
            // 
            // lv_attend_list
            // 
            this.lv_attend_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_attend_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_attend_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attendstudent_id,
            this.attendstudent_name});
            this.lv_attend_list.Depth = 0;
            this.lv_attend_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lv_attend_list.FullRowSelect = true;
            this.lv_attend_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_attend_list.Location = new System.Drawing.Point(6, 7);
            this.lv_attend_list.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_attend_list.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_attend_list.Name = "lv_attend_list";
            this.lv_attend_list.OwnerDraw = true;
            this.lv_attend_list.Size = new System.Drawing.Size(767, 210);
            this.lv_attend_list.TabIndex = 1;
            this.lv_attend_list.UseCompatibleStateImageBehavior = false;
            this.lv_attend_list.View = System.Windows.Forms.View.Details;
            // 
            // attendstudent_id
            // 
            this.attendstudent_id.Text = "ID";
            this.attendstudent_id.Width = 350;
            // 
            // attendstudent_name
            // 
            this.attendstudent_name.Text = "이름";
            this.attendstudent_name.Width = 350;
            // 
            // rb_attend_submit
            // 
            this.rb_attend_submit.AutoSize = true;
            this.rb_attend_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_attend_submit.Depth = 0;
            this.rb_attend_submit.Icon = null;
            this.rb_attend_submit.Location = new System.Drawing.Point(675, 223);
            this.rb_attend_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_attend_submit.Name = "rb_attend_submit";
            this.rb_attend_submit.Primary = true;
            this.rb_attend_submit.Size = new System.Drawing.Size(98, 36);
            this.rb_attend_submit.TabIndex = 0;
            this.rb_attend_submit.Text = "출석체크";
            this.rb_attend_submit.UseVisualStyleBackColor = true;
            this.rb_attend_submit.Click += new System.EventHandler(this.rb_attend_submit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 495);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.lb_mainpage_sex);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "관리";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Tab.ResumeLayout(false);
            this.mainpage.ResumeLayout(false);
            this.mainpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainpage_image)).EndInit();
            this.addstudentpage.ResumeLayout(false);
            this.addstudentpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addstudent_image)).EndInit();
            this.renewstudentpage.ResumeLayout(false);
            this.renewstudentpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_renewstudent_image)).EndInit();
            this.checkpage.ResumeLayout(false);
            this.checkpage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialDivider lb_mainpage_sex;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl Tab;
        private System.Windows.Forms.TabPage mainpage;
        private System.Windows.Forms.TabPage addstudentpage;
        private System.Windows.Forms.TabPage renewstudentpage;
        private TabPage checkpage;
        private MaterialLabel lb_addstudent_sex;
        private MaterialRaisedButton rb_addstudent_submit;
        private MaterialSingleLineTextField tf_addstudent_name;
        private MaterialLabel lb_renewstudent_sex;
        private MaterialRaisedButton rb_renewstudent_submit;
        private MaterialSingleLineTextField tf_renewstudent_search;
        private MaterialSingleLineTextField tf_renewstudent_name;
        private MaterialRaisedButton rb_attend_submit;
        private MaterialSingleLineTextField tf_addstudent_lecture;
        private MaterialSingleLineTextField tf_addstudent_outdate;
        private MaterialSingleLineTextField tf_addstudent_schoolclass;
        private MaterialSingleLineTextField tf_addstudent_grade;
        private MaterialSingleLineTextField tf_addstudent_schoolname;
        private MaterialSingleLineTextField tf_addstudent_address;
        private MaterialSingleLineTextField tf_addstudent_rejoindate;
        private MaterialSingleLineTextField tf_addstudent_phone;
        private MaterialSingleLineTextField tf_addstudent_birthday;
        private MaterialLabel materialLabel1;
        private MaterialLabel lb_mainpage_id;
        private MaterialSingleLineTextField tf_renewstudent_birthday;
        private MaterialSingleLineTextField tf_renewstudent_lecture;
        private MaterialSingleLineTextField tf_renewstudent_outdate;
        private MaterialSingleLineTextField tf_renewstudent_schoolclass;
        private MaterialSingleLineTextField tf_renewstudent_grade;
        private MaterialSingleLineTextField tf_renewstudent_schoolName;
        private MaterialSingleLineTextField tf_renewstudent_address;
        private MaterialSingleLineTextField tf_renewstudent_rejoindate;
        private MaterialSingleLineTextField tf_renewstudent_joindate;
        private MaterialSingleLineTextField tf_renewstudent_phone;
        private MaterialLabel lb_mainpage_join;
        private MaterialRaisedButton rb_mainpage_ban;
        private MaterialSingleLineTextField tf_mainpage_search;
        private MaterialLabel lb_mainpage_shoolclass;
        private MaterialLabel lb_mainpage_grade;
        private MaterialLabel lb_mainpage_school;
        private MaterialLabel lb_mainpage_address;
        private MaterialLabel lb_mainpage_phone;
        private MaterialLabel lb_mainpage_name;
        private MaterialLabel lb_mainpage_outdate;
        private MaterialLabel lb_mainpage_rejoindate;
        private MaterialLabel lb_mainpage_birthday;
        private MaterialLabel lb_mainpage_lecture;
        private MaterialSingleLineTextField tf_addstudent_joindate;
        private MaterialListView lv_attend_list;
        private PictureBox pb_addstudent_image;
        private PictureBox pb_mainpage_image;
        private PictureBox pb_renewstudent_image;
        private MaterialLabel lb_addstudent_searchimage;
        private ColumnHeader attendstudent_id;
        private ColumnHeader attendstudent_name;
    }
}