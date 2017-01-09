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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Icon = null;
            this.RegisterButton.Location = new System.Drawing.Point(131, 201);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(83, 36);
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
            this.SubmitButton.Location = new System.Drawing.Point(33, 201);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(71, 36);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // tf_login_pw
            // 
            this.tf_login_pw.Depth = 0;
            this.tf_login_pw.Hint = "Password";
            this.tf_login_pw.Location = new System.Drawing.Point(33, 136);
            this.tf_login_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_login_pw.MaxLength = 32767;
            this.tf_login_pw.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_login_pw.Name = "tf_login_pw";
            this.tf_login_pw.PasswordChar = '*';
            this.tf_login_pw.SelectedText = "";
            this.tf_login_pw.SelectionLength = 0;
            this.tf_login_pw.SelectionStart = 0;
            this.tf_login_pw.Size = new System.Drawing.Size(181, 23);
            this.tf_login_pw.TabIndex = 5;
            this.tf_login_pw.TabStop = false;
            this.tf_login_pw.UseSystemPasswordChar = false;
            this.tf_login_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_login_pw_KeyDown);
            // 
            // tf_login_id
            // 
            this.tf_login_id.Depth = 0;
            this.tf_login_id.Hint = "ID";
            this.tf_login_id.Location = new System.Drawing.Point(33, 88);
            this.tf_login_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tf_login_id.MaxLength = 32767;
            this.tf_login_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_login_id.Name = "tf_login_id";
            this.tf_login_id.PasswordChar = '\0';
            this.tf_login_id.SelectedText = "";
            this.tf_login_id.SelectionLength = 0;
            this.tf_login_id.SelectionStart = 0;
            this.tf_login_id.Size = new System.Drawing.Size(181, 23);
            this.tf_login_id.TabIndex = 4;
            this.tf_login_id.TabStop = false;
            this.tf_login_id.UseSystemPasswordChar = false;
            this.tf_login_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tf_login_id_KeyDown);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 180);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(181, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 268);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.tf_login_pw);
            this.Controls.Add(this.tf_login_id);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}