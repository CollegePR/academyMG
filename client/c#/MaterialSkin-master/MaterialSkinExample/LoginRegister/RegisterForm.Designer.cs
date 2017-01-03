namespace MaterialSkinExample
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
            this.tf_register_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_password_compare = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_register_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fb_register_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rb_register_class = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tf_register_id
            // 
            this.tf_register_id.Depth = 0;
            this.tf_register_id.Hint = "";
            this.tf_register_id.Location = new System.Drawing.Point(12, 84);
            this.tf_register_id.MaxLength = 32767;
            this.tf_register_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_id.Name = "tf_register_id";
            this.tf_register_id.PasswordChar = '\0';
            this.tf_register_id.SelectedText = "";
            this.tf_register_id.SelectionLength = 0;
            this.tf_register_id.SelectionStart = 0;
            this.tf_register_id.Size = new System.Drawing.Size(75, 28);
            this.tf_register_id.TabIndex = 0;
            this.tf_register_id.TabStop = false;
            this.tf_register_id.Text = "ID";
            this.tf_register_id.UseSystemPasswordChar = false;
            // 
            // tf_register_password
            // 
            this.tf_register_password.Depth = 0;
            this.tf_register_password.Hint = "";
            this.tf_register_password.Location = new System.Drawing.Point(13, 119);
            this.tf_register_password.MaxLength = 32767;
            this.tf_register_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_password.Name = "tf_register_password";
            this.tf_register_password.PasswordChar = '\0';
            this.tf_register_password.SelectedText = "";
            this.tf_register_password.SelectionLength = 0;
            this.tf_register_password.SelectionStart = 0;
            this.tf_register_password.Size = new System.Drawing.Size(75, 28);
            this.tf_register_password.TabIndex = 1;
            this.tf_register_password.TabStop = false;
            this.tf_register_password.Text = "PW";
            this.tf_register_password.UseSystemPasswordChar = false;
            // 
            // tf_register_password_compare
            // 
            this.tf_register_password_compare.Depth = 0;
            this.tf_register_password_compare.Hint = "";
            this.tf_register_password_compare.Location = new System.Drawing.Point(13, 154);
            this.tf_register_password_compare.MaxLength = 32767;
            this.tf_register_password_compare.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_password_compare.Name = "tf_register_password_compare";
            this.tf_register_password_compare.PasswordChar = '\0';
            this.tf_register_password_compare.SelectedText = "";
            this.tf_register_password_compare.SelectionLength = 0;
            this.tf_register_password_compare.SelectionStart = 0;
            this.tf_register_password_compare.Size = new System.Drawing.Size(75, 28);
            this.tf_register_password_compare.TabIndex = 2;
            this.tf_register_password_compare.TabStop = false;
            this.tf_register_password_compare.Text = "PW CMP";
            this.tf_register_password_compare.UseSystemPasswordChar = false;
            // 
            // tf_register_name
            // 
            this.tf_register_name.Depth = 0;
            this.tf_register_name.Hint = "";
            this.tf_register_name.Location = new System.Drawing.Point(250, 154);
            this.tf_register_name.MaxLength = 32767;
            this.tf_register_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_register_name.Name = "tf_register_name";
            this.tf_register_name.PasswordChar = '\0';
            this.tf_register_name.SelectedText = "";
            this.tf_register_name.SelectionLength = 0;
            this.tf_register_name.SelectionStart = 0;
            this.tf_register_name.Size = new System.Drawing.Size(75, 28);
            this.tf_register_name.TabIndex = 4;
            this.tf_register_name.TabStop = false;
            this.tf_register_name.Text = "Name";
            this.tf_register_name.UseSystemPasswordChar = false;
            // 
            // fb_register_submit
            // 
            this.fb_register_submit.AutoSize = true;
            this.fb_register_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fb_register_submit.Depth = 0;
            this.fb_register_submit.Icon = null;
            this.fb_register_submit.Location = new System.Drawing.Point(125, 295);
            this.fb_register_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.fb_register_submit.Name = "fb_register_submit";
            this.fb_register_submit.Primary = true;
            this.fb_register_submit.Size = new System.Drawing.Size(85, 36);
            this.fb_register_submit.TabIndex = 5;
            this.fb_register_submit.Text = "Submit";
            this.fb_register_submit.UseVisualStyleBackColor = true;
            // 
            // rb_register_class
            // 
            this.rb_register_class.AutoSize = true;
            this.rb_register_class.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_register_class.Depth = 0;
            this.rb_register_class.Icon = null;
            this.rb_register_class.Location = new System.Drawing.Point(250, 84);
            this.rb_register_class.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_register_class.Name = "rb_register_class";
            this.rb_register_class.Primary = true;
            this.rb_register_class.Size = new System.Drawing.Size(75, 36);
            this.rb_register_class.TabIndex = 6;
            this.rb_register_class.Text = "Class";
            this.rb_register_class.UseVisualStyleBackColor = true;
            this.rb_register_class.Click += new System.EventHandler(this.rb_register_class_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 343);
            this.Controls.Add(this.rb_register_class);
            this.Controls.Add(this.fb_register_submit);
            this.Controls.Add(this.tf_register_name);
            this.Controls.Add(this.tf_register_password_compare);
            this.Controls.Add(this.tf_register_password);
            this.Controls.Add(this.tf_register_id);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_id;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_password_compare;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_register_name;
        private MaterialSkin.Controls.MaterialRaisedButton fb_register_submit;
        private MaterialSkin.Controls.MaterialRaisedButton rb_register_class;
    }
}