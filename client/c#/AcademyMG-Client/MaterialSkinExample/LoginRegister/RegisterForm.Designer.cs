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
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButton.Depth = 0;
            this.SubmitButton.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SubmitButton.Icon = null;
            this.SubmitButton.Location = new System.Drawing.Point(253, 268);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(60, 36);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "가입";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // tf_register_name
            // 
            this.tf_register_name.Depth = 0;
            this.tf_register_name.Hint = "이름";
            this.tf_register_name.Location = new System.Drawing.Point(14, 121);
            this.tf_register_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_name.MaxLength = 32767;
            this.tf_register_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_name.Name = "tf_register_name";
            this.tf_register_name.PasswordChar = '\0';
            this.tf_register_name.SelectedText = "";
            this.tf_register_name.SelectionLength = 0;
            this.tf_register_name.SelectionStart = 0;
            this.tf_register_name.Size = new System.Drawing.Size(297, 28);
            this.tf_register_name.TabIndex = 10;
            this.tf_register_name.TabStop = false;
            this.tf_register_name.UseSystemPasswordChar = false;
            // 
            // tf_register_class
            // 
            this.tf_register_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tf_register_class.Depth = 0;
            this.tf_register_class.Enabled = false;
            this.tf_register_class.Hint = "학급명";
            this.tf_register_class.Location = new System.Drawing.Point(14, 222);
            this.tf_register_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_class.MaxLength = 32767;
            this.tf_register_class.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_class.Name = "tf_register_class";
            this.tf_register_class.PasswordChar = '\0';
            this.tf_register_class.SelectedText = "";
            this.tf_register_class.SelectionLength = 0;
            this.tf_register_class.SelectionStart = 0;
            this.tf_register_class.Size = new System.Drawing.Size(297, 28);
            this.tf_register_class.TabIndex = 9;
            this.tf_register_class.TabStop = false;
            this.tf_register_class.UseSystemPasswordChar = false;
            this.tf_register_class.Click += new System.EventHandler(this.tf_register_class_Click);
            // 
            // tf_register_pwcmp
            // 
            this.tf_register_pwcmp.Depth = 0;
            this.tf_register_pwcmp.Hint = "비밀번호확인";
            this.tf_register_pwcmp.Location = new System.Drawing.Point(14, 189);
            this.tf_register_pwcmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_pwcmp.MaxLength = 32767;
            this.tf_register_pwcmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_pwcmp.Name = "tf_register_pwcmp";
            this.tf_register_pwcmp.PasswordChar = '\0';
            this.tf_register_pwcmp.SelectedText = "";
            this.tf_register_pwcmp.SelectionLength = 0;
            this.tf_register_pwcmp.SelectionStart = 0;
            this.tf_register_pwcmp.Size = new System.Drawing.Size(297, 28);
            this.tf_register_pwcmp.TabIndex = 8;
            this.tf_register_pwcmp.TabStop = false;
            this.tf_register_pwcmp.UseSystemPasswordChar = false;
            // 
            // tf_register_pw
            // 
            this.tf_register_pw.Depth = 0;
            this.tf_register_pw.Hint = "비밀번호";
            this.tf_register_pw.Location = new System.Drawing.Point(14, 155);
            this.tf_register_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_pw.MaxLength = 32767;
            this.tf_register_pw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_pw.Name = "tf_register_pw";
            this.tf_register_pw.PasswordChar = '\0';
            this.tf_register_pw.SelectedText = "";
            this.tf_register_pw.SelectionLength = 0;
            this.tf_register_pw.SelectionStart = 0;
            this.tf_register_pw.Size = new System.Drawing.Size(297, 28);
            this.tf_register_pw.TabIndex = 7;
            this.tf_register_pw.TabStop = false;
            this.tf_register_pw.UseSystemPasswordChar = false;
            // 
            // tf_register_id
            // 
            this.tf_register_id.Depth = 0;
            this.tf_register_id.Hint = "아이디";
            this.tf_register_id.Location = new System.Drawing.Point(14, 88);
            this.tf_register_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_register_id.MaxLength = 32767;
            this.tf_register_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_id.Name = "tf_register_id";
            this.tf_register_id.PasswordChar = '\0';
            this.tf_register_id.SelectedText = "";
            this.tf_register_id.SelectionLength = 0;
            this.tf_register_id.SelectionStart = 0;
            this.tf_register_id.Size = new System.Drawing.Size(297, 28);
            this.tf_register_id.TabIndex = 6;
            this.tf_register_id.TabStop = false;
            this.tf_register_id.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(187, 268);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(60, 36);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "취소";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 326);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.tf_register_name);
            this.Controls.Add(this.tf_register_class);
            this.Controls.Add(this.tf_register_pwcmp);
            this.Controls.Add(this.tf_register_pw);
            this.Controls.Add(this.tf_register_id);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}