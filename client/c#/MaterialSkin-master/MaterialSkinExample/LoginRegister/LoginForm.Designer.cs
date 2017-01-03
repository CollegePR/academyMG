namespace MaterialSkinExample
{
    partial class LoginForm
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
            this.tf_login_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_login_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fb_login_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fb_login_register = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tf_login_id
            // 
            this.tf_login_id.Depth = 0;
            this.tf_login_id.Hint = "";
            this.tf_login_id.Location = new System.Drawing.Point(44, 92);
            this.tf_login_id.MaxLength = 32767;
            this.tf_login_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_login_id.Name = "tf_login_id";
            this.tf_login_id.PasswordChar = '\0';
            this.tf_login_id.SelectedText = "";
            this.tf_login_id.SelectionLength = 0;
            this.tf_login_id.SelectionStart = 0;
            this.tf_login_id.Size = new System.Drawing.Size(207, 28);
            this.tf_login_id.TabIndex = 0;
            this.tf_login_id.TabStop = false;
            this.tf_login_id.Text = "ID";
            this.tf_login_id.UseSystemPasswordChar = false;
            // 
            // tf_login_password
            // 
            this.tf_login_password.Depth = 0;
            this.tf_login_password.Hint = "";
            this.tf_login_password.Location = new System.Drawing.Point(44, 138);
            this.tf_login_password.MaxLength = 32767;
            this.tf_login_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_login_password.Name = "tf_login_password";
            this.tf_login_password.PasswordChar = '\0';
            this.tf_login_password.SelectedText = "";
            this.tf_login_password.SelectionLength = 0;
            this.tf_login_password.SelectionStart = 0;
            this.tf_login_password.Size = new System.Drawing.Size(207, 28);
            this.tf_login_password.TabIndex = 1;
            this.tf_login_password.TabStop = false;
            this.tf_login_password.Text = "PW";
            this.tf_login_password.UseSystemPasswordChar = false;
            // 
            // fb_login_submit
            // 
            this.fb_login_submit.AutoSize = true;
            this.fb_login_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fb_login_submit.Depth = 0;
            this.fb_login_submit.Icon = null;
            this.fb_login_submit.Location = new System.Drawing.Point(44, 206);
            this.fb_login_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.fb_login_submit.Name = "fb_login_submit";
            this.fb_login_submit.Padding = new System.Windows.Forms.Padding(20);
            this.fb_login_submit.Primary = true;
            this.fb_login_submit.Size = new System.Drawing.Size(85, 36);
            this.fb_login_submit.TabIndex = 2;
            this.fb_login_submit.Text = "SUBMIT";
            this.fb_login_submit.UseVisualStyleBackColor = true;
            this.fb_login_submit.Click += new System.EventHandler(this.fb_login_submit_Click);
            // 
            // fb_login_register
            // 
            this.fb_login_register.AutoSize = true;
            this.fb_login_register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fb_login_register.Depth = 0;
            this.fb_login_register.Icon = null;
            this.fb_login_register.Location = new System.Drawing.Point(151, 206);
            this.fb_login_register.MouseState = MaterialSkin.MouseState.HOVER;
            this.fb_login_register.Name = "fb_login_register";
            this.fb_login_register.Primary = true;
            this.fb_login_register.Size = new System.Drawing.Size(100, 36);
            this.fb_login_register.TabIndex = 3;
            this.fb_login_register.Text = "Register";
            this.fb_login_register.UseVisualStyleBackColor = true;
            this.fb_login_register.Click += new System.EventHandler(this.fb_login_register_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 289);
            this.Controls.Add(this.fb_login_register);
            this.Controls.Add(this.fb_login_submit);
            this.Controls.Add(this.tf_login_password);
            this.Controls.Add(this.tf_login_id);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tf_login_id;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_login_password;
        private MaterialSkin.Controls.MaterialRaisedButton fb_login_submit;
        private MaterialSkin.Controls.MaterialRaisedButton fb_login_register;
    }
}