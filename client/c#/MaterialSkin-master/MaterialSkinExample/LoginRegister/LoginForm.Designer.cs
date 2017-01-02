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
            this.IDInputfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PWInputfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SubmitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RegisterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // IDInputfield
            // 
            this.IDInputfield.Depth = 0;
            this.IDInputfield.Hint = "";
            this.IDInputfield.Location = new System.Drawing.Point(44, 92);
            this.IDInputfield.MaxLength = 32767;
            this.IDInputfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDInputfield.Name = "IDInputfield";
            this.IDInputfield.PasswordChar = '\0';
            this.IDInputfield.SelectedText = "";
            this.IDInputfield.SelectionLength = 0;
            this.IDInputfield.SelectionStart = 0;
            this.IDInputfield.Size = new System.Drawing.Size(207, 28);
            this.IDInputfield.TabIndex = 0;
            this.IDInputfield.TabStop = false;
            this.IDInputfield.Text = "ID";
            this.IDInputfield.UseSystemPasswordChar = false;
            // 
            // PWInputfield
            // 
            this.PWInputfield.Depth = 0;
            this.PWInputfield.Hint = "";
            this.PWInputfield.Location = new System.Drawing.Point(44, 138);
            this.PWInputfield.MaxLength = 32767;
            this.PWInputfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWInputfield.Name = "PWInputfield";
            this.PWInputfield.PasswordChar = '\0';
            this.PWInputfield.SelectedText = "";
            this.PWInputfield.SelectionLength = 0;
            this.PWInputfield.SelectionStart = 0;
            this.PWInputfield.Size = new System.Drawing.Size(207, 28);
            this.PWInputfield.TabIndex = 1;
            this.PWInputfield.TabStop = false;
            this.PWInputfield.Text = "PW";
            this.PWInputfield.UseSystemPasswordChar = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButton.Depth = 0;
            this.SubmitButton.Icon = null;
            this.SubmitButton.Location = new System.Drawing.Point(44, 206);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Padding = new System.Windows.Forms.Padding(20);
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(85, 36);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Icon = null;
            this.RegisterButton.Location = new System.Drawing.Point(151, 206);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(100, 36);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 289);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PWInputfield);
            this.Controls.Add(this.IDInputfield);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField IDInputfield;
        private MaterialSkin.Controls.MaterialSingleLineTextField PWInputfield;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitButton;
        private MaterialSkin.Controls.MaterialRaisedButton RegisterButton;
    }
}