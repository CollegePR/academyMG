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
            this.rb_attend_submit = new MaterialSkin.Controls.MaterialTabControl();
            this.mainpage = new System.Windows.Forms.TabPage();
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
            this.dv_mainpage_image = new MaterialSkin.Controls.MaterialDivider();
            this.addstudentpage = new System.Windows.Forms.TabPage();
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
            this.dv_addstudent_image = new MaterialSkin.Controls.MaterialDivider();
            this.renewstudentpage = new System.Windows.Forms.TabPage();
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
            this.dv_renewstudent_image = new MaterialSkin.Controls.MaterialDivider();
            this.checkpage = new System.Windows.Forms.TabPage();
            this.rb_ = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.rb_attend_submit.SuspendLayout();
            this.mainpage.SuspendLayout();
            this.addstudentpage.SuspendLayout();
            this.renewstudentpage.SuspendLayout();
            this.checkpage.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
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
            this.materialTabSelector1.BaseTabControl = this.rb_attend_submit;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 74);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(833, 55);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // rb_attend_submit
            // 
            this.rb_attend_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_attend_submit.Controls.Add(this.mainpage);
            this.rb_attend_submit.Controls.Add(this.addstudentpage);
            this.rb_attend_submit.Controls.Add(this.renewstudentpage);
            this.rb_attend_submit.Controls.Add(this.checkpage);
            this.rb_attend_submit.Depth = 0;
            this.rb_attend_submit.Location = new System.Drawing.Point(18, 128);
            this.rb_attend_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_attend_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_attend_submit.Name = "rb_attend_submit";
            this.rb_attend_submit.SelectedIndex = 0;
            this.rb_attend_submit.Size = new System.Drawing.Size(787, 295);
            this.rb_attend_submit.TabIndex = 18;
            // 
            // mainpage
            // 
            this.mainpage.BackColor = System.Drawing.Color.White;
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
            this.mainpage.Controls.Add(this.dv_mainpage_image);
            this.mainpage.Location = new System.Drawing.Point(4, 25);
            this.mainpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainpage.Name = "mainpage";
            this.mainpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainpage.Size = new System.Drawing.Size(779, 266);
            this.mainpage.TabIndex = 0;
            this.mainpage.Text = "메인화면";
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
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(108, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(25, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "남";
            // 
            // lb_mainpage_id
            // 
            this.lb_mainpage_id.AutoSize = true;
            this.lb_mainpage_id.Depth = 0;
            this.lb_mainpage_id.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_mainpage_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_mainpage_id.Location = new System.Drawing.Point(6, 106);
            this.lb_mainpage_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mainpage_id.Name = "lb_mainpage_id";
            this.lb_mainpage_id.Size = new System.Drawing.Size(70, 24);
            this.lb_mainpage_id.TabIndex = 2;
            this.lb_mainpage_id.Text = "학생번호";
            // 
            // dv_mainpage_image
            // 
            this.dv_mainpage_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dv_mainpage_image.Depth = 0;
            this.dv_mainpage_image.Location = new System.Drawing.Point(6, 7);
            this.dv_mainpage_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.dv_mainpage_image.Name = "dv_mainpage_image";
            this.dv_mainpage_image.Size = new System.Drawing.Size(127, 123);
            this.dv_mainpage_image.TabIndex = 1;
            this.dv_mainpage_image.Text = "materialDivider2";
            // 
            // addstudentpage
            // 
            this.addstudentpage.BackColor = System.Drawing.Color.White;
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
            this.addstudentpage.Controls.Add(this.dv_addstudent_image);
            this.addstudentpage.Location = new System.Drawing.Point(4, 25);
            this.addstudentpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addstudentpage.Name = "addstudentpage";
            this.addstudentpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addstudentpage.Size = new System.Drawing.Size(779, 266);
            this.addstudentpage.TabIndex = 1;
            this.addstudentpage.Text = "원생추가";
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
            this.tf_addstudent_name.Size = new System.Drawing.Size(133, 28);
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
            this.lb_addstudent_sex.Depth = 0;
            this.lb_addstudent_sex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_addstudent_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_addstudent_sex.Location = new System.Drawing.Point(114, 130);
            this.lb_addstudent_sex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_addstudent_sex.Name = "lb_addstudent_sex";
            this.lb_addstudent_sex.Size = new System.Drawing.Size(25, 24);
            this.lb_addstudent_sex.TabIndex = 0;
            this.lb_addstudent_sex.Text = "남";
            this.lb_addstudent_sex.Click += new System.EventHandler(this.lb_addstudent_sex_Click);
            // 
            // dv_addstudent_image
            // 
            this.dv_addstudent_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dv_addstudent_image.Depth = 0;
            this.dv_addstudent_image.Location = new System.Drawing.Point(6, 7);
            this.dv_addstudent_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.dv_addstudent_image.Name = "dv_addstudent_image";
            this.dv_addstudent_image.Size = new System.Drawing.Size(133, 147);
            this.dv_addstudent_image.TabIndex = 2;
            this.dv_addstudent_image.Text = "materialDivider2";
            // 
            // renewstudentpage
            // 
            this.renewstudentpage.BackColor = System.Drawing.Color.White;
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
            this.renewstudentpage.Controls.Add(this.dv_renewstudent_image);
            this.renewstudentpage.Location = new System.Drawing.Point(4, 25);
            this.renewstudentpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.renewstudentpage.Name = "renewstudentpage";
            this.renewstudentpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.renewstudentpage.Size = new System.Drawing.Size(779, 266);
            this.renewstudentpage.TabIndex = 2;
            this.renewstudentpage.Text = "원생재갱신";
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
            this.tf_renewstudent_name.Size = new System.Drawing.Size(122, 28);
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
            this.lb_renewstudent_sex.Depth = 0;
            this.lb_renewstudent_sex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_renewstudent_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_renewstudent_sex.Location = new System.Drawing.Point(100, 122);
            this.lb_renewstudent_sex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_renewstudent_sex.Name = "lb_renewstudent_sex";
            this.lb_renewstudent_sex.Size = new System.Drawing.Size(25, 24);
            this.lb_renewstudent_sex.TabIndex = 1;
            this.lb_renewstudent_sex.Text = "남";
            this.lb_renewstudent_sex.Click += new System.EventHandler(this.lb_renewstudent_sex_Click);
            // 
            // dv_renewstudent_image
            // 
            this.dv_renewstudent_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dv_renewstudent_image.Depth = 0;
            this.dv_renewstudent_image.Location = new System.Drawing.Point(6, 7);
            this.dv_renewstudent_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.dv_renewstudent_image.Name = "dv_renewstudent_image";
            this.dv_renewstudent_image.Size = new System.Drawing.Size(119, 139);
            this.dv_renewstudent_image.TabIndex = 0;
            this.dv_renewstudent_image.Text = "materialDivider3";
            // 
            // checkpage
            // 
            this.checkpage.Controls.Add(this.rb_);
            this.checkpage.Location = new System.Drawing.Point(4, 25);
            this.checkpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkpage.Name = "checkpage";
            this.checkpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkpage.Size = new System.Drawing.Size(779, 266);
            this.checkpage.TabIndex = 3;
            this.checkpage.Text = "출석체크";
            this.checkpage.UseVisualStyleBackColor = true;
            // 
            // rb_
            // 
            this.rb_.AutoSize = true;
            this.rb_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_.Depth = 0;
            this.rb_.Icon = null;
            this.rb_.Location = new System.Drawing.Point(675, 223);
            this.rb_.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_.Name = "rb_";
            this.rb_.Primary = true;
            this.rb_.Size = new System.Drawing.Size(98, 36);
            this.rb_.TabIndex = 0;
            this.rb_.Text = "출석체크";
            this.rb_.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(200, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 495);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.rb_attend_submit);
            this.Controls.Add(this.lb_mainpage_sex);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "관리";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rb_attend_submit.ResumeLayout(false);
            this.mainpage.ResumeLayout(false);
            this.mainpage.PerformLayout();
            this.addstudentpage.ResumeLayout(false);
            this.addstudentpage.PerformLayout();
            this.renewstudentpage.ResumeLayout(false);
            this.renewstudentpage.PerformLayout();
            this.checkpage.ResumeLayout(false);
            this.checkpage.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialDivider lb_mainpage_sex;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl rb_attend_submit;
        private System.Windows.Forms.TabPage mainpage;
        private System.Windows.Forms.TabPage addstudentpage;
        private System.Windows.Forms.TabPage renewstudentpage;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private TabPage checkpage;
        private MaterialLabel lb_addstudent_sex;
        private MaterialDivider dv_addstudent_image;
        private MaterialRaisedButton rb_addstudent_submit;
        private MaterialSingleLineTextField tf_addstudent_name;
        private MaterialLabel lb_renewstudent_sex;
        private MaterialDivider dv_renewstudent_image;
        private MaterialRaisedButton rb_renewstudent_submit;
        private MaterialSingleLineTextField tf_renewstudent_search;
        private MaterialSingleLineTextField tf_renewstudent_name;
        private MaterialRaisedButton rb_;
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
        private MaterialDivider dv_mainpage_image;
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
    }
}