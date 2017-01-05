namespace MaterialSkinExample.LoginRegister
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
            this.RegisterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SubmitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tf_login_pw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_login_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Icon = null;
            this.RegisterButton.Location = new System.Drawing.Point(150, 251);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(100, 36);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButton.Depth = 0;
            this.SubmitButton.Icon = null;
            this.SubmitButton.Location = new System.Drawing.Point(38, 251);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Padding = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(85, 36);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // tf_login_pw
            // 
            this.tf_login_pw.Depth = 0;
            this.tf_login_pw.Hint = "Password";
            this.tf_login_pw.Location = new System.Drawing.Point(38, 170);
            this.tf_login_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_login_pw.MaxLength = 32767;
            this.tf_login_pw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_login_pw.Name = "tf_login_pw";
            this.tf_login_pw.PasswordChar = '*';
            this.tf_login_pw.SelectedText = "";
            this.tf_login_pw.SelectionLength = 0;
            this.tf_login_pw.SelectionStart = 0;
            this.tf_login_pw.Size = new System.Drawing.Size(207, 28);
            this.tf_login_pw.TabIndex = 5;
            this.tf_login_pw.TabStop = false;
            this.tf_login_pw.UseSystemPasswordChar = false;
            // 
            // tf_login_id
            // 
            this.tf_login_id.Depth = 0;
            this.tf_login_id.Hint = "ID";
            this.tf_login_id.Location = new System.Drawing.Point(38, 110);
            this.tf_login_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_login_id.MaxLength = 32767;
            this.tf_login_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_login_id.Name = "tf_login_id";
            this.tf_login_id.PasswordChar = '\0';
            this.tf_login_id.SelectedText = "";
            this.tf_login_id.SelectionLength = 0;
            this.tf_login_id.SelectionStart = 0;
            this.tf_login_id.Size = new System.Drawing.Size(207, 28);
            this.tf_login_id.TabIndex = 4;
            this.tf_login_id.TabStop = false;
            this.tf_login_id.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(197, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel1.Size = new System.Drawing.Size(0, 24);
            this.materialLabel1.TabIndex = 8;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(114, 225);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel2.Size = new System.Drawing.Size(0, 24);
            this.materialLabel2.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 335);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.tf_login_pw);
            this.Controls.Add(this.tf_login_id);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton RegisterButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_login_pw;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_login_id;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}