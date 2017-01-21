namespace MaterialSkinExample
{
    partial class Form1
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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.School_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.School_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_of_admission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_of_readmission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_of_exit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Class,
            this.Phone_num,
            this.Address,
            this.School_name,
            this.Grade,
            this.School_class,
            this.Date_of_admission,
            this.Date_of_readmission,
            this.Date_of_exit,
            this.Birthday});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(0, 63);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(300, 238);
            this.materialListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.materialListView1.TabIndex = 12;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 70;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name.Width = 100;
            // 
            // Class
            // 
            this.Class.Text = "Class";
            this.Class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Class.Width = 100;
            // 
            // Phone_num
            // 
            this.Phone_num.Text = "Phone_num";
            this.Phone_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone_num.Width = 150;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 200;
            // 
            // School_name
            // 
            this.School_name.Text = "School_name";
            this.School_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.School_name.Width = 100;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Grade.Width = 100;
            // 
            // School_class
            // 
            this.School_class.Text = "School_class";
            this.School_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.School_class.Width = 100;
            // 
            // Date_of_admission
            // 
            this.Date_of_admission.Text = "Date_of_admission";
            this.Date_of_admission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date_of_admission.Width = 150;
            // 
            // Date_of_readmission
            // 
            this.Date_of_readmission.Text = "Date_of_readmission";
            this.Date_of_readmission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date_of_readmission.Width = 150;
            // 
            // Date_of_exit
            // 
            this.Date_of_exit.Text = "Date_of_exit";
            this.Date_of_exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date_of_exit.Width = 150;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Birthday";
            this.Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Birthday.Width = 200;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialRaisedButton1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 300);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(300, 36);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "선택";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 336);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialListView1);
            //this.Name = "Form1";
            this.Text = "중복 원생선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Phone_num;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader School_name;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader School_class;
        private System.Windows.Forms.ColumnHeader Date_of_admission;
        private System.Windows.Forms.ColumnHeader Date_of_readmission;
        private System.Windows.Forms.ColumnHeader Date_of_exit;
        private System.Windows.Forms.ColumnHeader Birthday;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ColumnHeader ID;
    }
}