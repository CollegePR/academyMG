namespace MaterialSkinExample.LoginRegister
{
    partial class RegisterForm
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
            this.SubmitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tf_register_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_class = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_pwcmp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_pw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButton.Depth = 0;
            this.SubmitButton.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SubmitButton.Icon = null;
            this.SubmitButton.Location = new System.Drawing.Point(221, 314);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(51, 36);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "가입";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // tf_register_name
            // 
            this.tf_register_name.Depth = 0;
            this.tf_register_name.Hint = "이름";
            this.tf_register_name.Location = new System.Drawing.Point(12, 116);
            this.tf_register_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_name.MaxLength = 32767;
            this.tf_register_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_name.Name = "tf_register_name";
            this.tf_register_name.PasswordChar = '\0';
            this.tf_register_name.SelectedText = "";
            this.tf_register_name.SelectionLength = 0;
            this.tf_register_name.SelectionStart = 0;
            this.tf_register_name.Size = new System.Drawing.Size(260, 23);
            this.tf_register_name.TabIndex = 7;
            this.tf_register_name.TabStop = false;
            this.tf_register_name.UseSystemPasswordChar = false;
            this.tf_register_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_register_name_KeyDown);
            // 
            // tf_register_class
            // 
            this.tf_register_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tf_register_class.Depth = 0;
            this.tf_register_class.Enabled = false;
            this.tf_register_class.Hint = "학급명";
            this.tf_register_class.Location = new System.Drawing.Point(12, 254);
            this.tf_register_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_class.MaxLength = 32767;
            this.tf_register_class.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_class.Name = "tf_register_class";
            this.tf_register_class.PasswordChar = '\0';
            this.tf_register_class.SelectedText = "";
            this.tf_register_class.SelectionLength = 0;
            this.tf_register_class.SelectionStart = 0;
            this.tf_register_class.Size = new System.Drawing.Size(260, 23);
            this.tf_register_class.TabIndex = 10;
            this.tf_register_class.TabStop = false;
            this.tf_register_class.UseSystemPasswordChar = false;
            this.tf_register_class.Click += new System.EventHandler(this.tf_register_class_Click);
            // 
            // tf_register_pwcmp
            // 
            this.tf_register_pwcmp.Depth = 0;
            this.tf_register_pwcmp.Hint = "비밀번호확인";
            this.tf_register_pwcmp.Location = new System.Drawing.Point(12, 208);
            this.tf_register_pwcmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_pwcmp.MaxLength = 32767;
            this.tf_register_pwcmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_pwcmp.Name = "tf_register_pwcmp";
            this.tf_register_pwcmp.PasswordChar = '*';
            this.tf_register_pwcmp.SelectedText = "";
            this.tf_register_pwcmp.SelectionLength = 0;
            this.tf_register_pwcmp.SelectionStart = 0;
            this.tf_register_pwcmp.Size = new System.Drawing.Size(260, 23);
            this.tf_register_pwcmp.TabIndex = 9;
            this.tf_register_pwcmp.TabStop = false;
            this.tf_register_pwcmp.UseSystemPasswordChar = false;
            this.tf_register_pwcmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_register_pwcmp_KeyDown);
            this.tf_register_pwcmp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tf_register_pwcmp_KeyUp);
            // 
            // tf_register_pw
            // 
            this.tf_register_pw.Depth = 0;
            this.tf_register_pw.Hint = "비밀번호";
            this.tf_register_pw.Location = new System.Drawing.Point(12, 162);
            this.tf_register_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_pw.MaxLength = 32767;
            this.tf_register_pw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_pw.Name = "tf_register_pw";
            this.tf_register_pw.PasswordChar = '*';
            this.tf_register_pw.SelectedText = "";
            this.tf_register_pw.SelectionLength = 0;
            this.tf_register_pw.SelectionStart = 0;
            this.tf_register_pw.Size = new System.Drawing.Size(260, 23);
            this.tf_register_pw.TabIndex = 8;
            this.tf_register_pw.TabStop = false;
            this.tf_register_pw.UseSystemPasswordChar = false;
            this.tf_register_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_register_pw_KeyDown);
            this.tf_register_pw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tf_register_pw_KeyUp);
            // 
            // tf_register_id
            // 
            this.tf_register_id.Depth = 0;
            this.tf_register_id.Hint = "아이디";
            this.tf_register_id.Location = new System.Drawing.Point(12, 70);
            this.tf_register_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_id.MaxLength = 32767;
            this.tf_register_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_id.Name = "tf_register_id";
            this.tf_register_id.PasswordChar = '\0';
            this.tf_register_id.SelectedText = "";
            this.tf_register_id.SelectionLength = 0;
            this.tf_register_id.SelectionStart = 0;
            this.tf_register_id.Size = new System.Drawing.Size(260, 23);
            this.tf_register_id.TabIndex = 6;
            this.tf_register_id.TabStop = false;
            this.tf_register_id.UseSystemPasswordChar = false;
            this.tf_register_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_register_id_KeyDown);
            this.tf_register_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tf_register_id_KeyUp);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(164, 314);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(51, 36);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "취소";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(260, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 141);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(260, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 187);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(260, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 233);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(260, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 279);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(260, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 314);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(146, 36);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.tf_register_name);
            this.Controls.Add(this.tf_register_class);
            this.Controls.Add(this.tf_register_pwcmp);
            this.Controls.Add(this.tf_register_pw);
            this.Controls.Add(this.tf_register_id);
            this.Name = "RegisterForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton SubmitButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_class;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_pwcmp;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_pw;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_id;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}