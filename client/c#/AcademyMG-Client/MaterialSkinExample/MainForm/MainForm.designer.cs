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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tf_addstudent_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rb_addstudent_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb_addstudent_sex = new MaterialSkin.Controls.MaterialLabel();
            this.lb_addstudent_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tf_renewstudent_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rb_renewstudent_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tf_renewstudent_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_renewstudent_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_renewstudent_sex = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialTabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 438);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(833, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 74);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(833, 55);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.MainPage);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(18, 128);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(787, 295);
            this.materialTabControl1.TabIndex = 18;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.White;
            this.MainPage.Controls.Add(this.materialListView1);
            this.MainPage.Location = new System.Drawing.Point(4, 25);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainPage.Size = new System.Drawing.Size(779, 266);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "메인화면";
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(26, 136);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(121, 97);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tf_addstudent_name);
            this.tabPage2.Controls.Add(this.rb_addstudent_submit);
            this.tabPage2.Controls.Add(this.lb_addstudent_sex);
            this.tabPage2.Controls.Add(this.lb_addstudent_id);
            this.tabPage2.Controls.Add(this.materialDivider2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(779, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "원생추가";
            // 
            // tf_addstudent_name
            // 
            this.tf_addstudent_name.Depth = 0;
            this.tf_addstudent_name.Hint = "";
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
            this.tf_addstudent_name.Text = "이름";
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
            // lb_addstudent_id
            // 
            this.lb_addstudent_id.Depth = 0;
            this.lb_addstudent_id.Hint = "";
            this.lb_addstudent_id.Location = new System.Drawing.Point(6, 126);
            this.lb_addstudent_id.MaxLength = 32767;
            this.lb_addstudent_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_addstudent_id.Name = "lb_addstudent_id";
            this.lb_addstudent_id.PasswordChar = '\0';
            this.lb_addstudent_id.SelectedText = "";
            this.lb_addstudent_id.SelectionLength = 0;
            this.lb_addstudent_id.SelectionStart = 0;
            this.lb_addstudent_id.Size = new System.Drawing.Size(75, 28);
            this.lb_addstudent_id.TabIndex = 1;
            this.lb_addstudent_id.TabStop = false;
            this.lb_addstudent_id.Text = "학생번호";
            this.lb_addstudent_id.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(6, 7);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(133, 147);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.tf_renewstudent_name);
            this.tabPage3.Controls.Add(this.rb_renewstudent_submit);
            this.tabPage3.Controls.Add(this.tf_renewstudent_search);
            this.tabPage3.Controls.Add(this.tf_renewstudent_id);
            this.tabPage3.Controls.Add(this.lb_renewstudent_sex);
            this.tabPage3.Controls.Add(this.materialDivider3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(779, 266);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "원생재갱신";
            // 
            // tf_renewstudent_name
            // 
            this.tf_renewstudent_name.Depth = 0;
            this.tf_renewstudent_name.Hint = "";
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
            this.tf_renewstudent_name.Text = "이름";
            this.tf_renewstudent_name.UseSystemPasswordChar = false;
            // 
            // rb_renewstudent_submit
            // 
            this.rb_renewstudent_submit.AutoSize = true;
            this.rb_renewstudent_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_renewstudent_submit.Depth = 0;
            this.rb_renewstudent_submit.Icon = null;
            this.rb_renewstudent_submit.Location = new System.Drawing.Point(652, 223);
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
            this.tf_renewstudent_search.Hint = "";
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
            this.tf_renewstudent_search.Text = "Search";
            this.tf_renewstudent_search.UseSystemPasswordChar = false;
            // 
            // tf_renewstudent_id
            // 
            this.tf_renewstudent_id.Depth = 0;
            this.tf_renewstudent_id.Hint = "";
            this.tf_renewstudent_id.Location = new System.Drawing.Point(6, 118);
            this.tf_renewstudent_id.MaxLength = 32767;
            this.tf_renewstudent_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_renewstudent_id.Name = "tf_renewstudent_id";
            this.tf_renewstudent_id.PasswordChar = '\0';
            this.tf_renewstudent_id.SelectedText = "";
            this.tf_renewstudent_id.SelectionLength = 0;
            this.tf_renewstudent_id.SelectionStart = 0;
            this.tf_renewstudent_id.Size = new System.Drawing.Size(75, 28);
            this.tf_renewstudent_id.TabIndex = 2;
            this.tf_renewstudent_id.TabStop = false;
            this.tf_renewstudent_id.Text = "학생번호";
            this.tf_renewstudent_id.UseSystemPasswordChar = false;
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
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(6, 7);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(119, 139);
            this.materialDivider3.TabIndex = 0;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(779, 266);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "출석체크";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "관리";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private TabPage tabPage4;
        private MaterialLabel lb_addstudent_sex;
        private MaterialSingleLineTextField lb_addstudent_id;
        private MaterialDivider materialDivider2;
        private MaterialRaisedButton rb_addstudent_submit;
        private MaterialSingleLineTextField tf_addstudent_name;
        private MaterialListView materialListView1;
        private MaterialLabel lb_renewstudent_sex;
        private MaterialDivider materialDivider3;
        private MaterialRaisedButton rb_renewstudent_submit;
        private MaterialSingleLineTextField tf_renewstudent_search;
        private MaterialSingleLineTextField tf_renewstudent_id;
        private MaterialSingleLineTextField tf_renewstudent_name;
    }
}