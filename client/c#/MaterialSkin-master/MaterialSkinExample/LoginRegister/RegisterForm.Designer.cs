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
            this.IDInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PWInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PWCMPInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ClassInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SubmitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // IDInputField
            // 
            this.IDInputField.Depth = 0;
            this.IDInputField.Hint = "";
            this.IDInputField.Location = new System.Drawing.Point(12, 84);
            this.IDInputField.MaxLength = 32767;
            this.IDInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDInputField.Name = "IDInputField";
            this.IDInputField.PasswordChar = '\0';
            this.IDInputField.SelectedText = "";
            this.IDInputField.SelectionLength = 0;
            this.IDInputField.SelectionStart = 0;
            this.IDInputField.Size = new System.Drawing.Size(75, 28);
            this.IDInputField.TabIndex = 0;
            this.IDInputField.TabStop = false;
            this.IDInputField.Text = "ID";
            this.IDInputField.UseSystemPasswordChar = false;
            // 
            // PWInputField
            // 
            this.PWInputField.Depth = 0;
            this.PWInputField.Hint = "";
            this.PWInputField.Location = new System.Drawing.Point(13, 119);
            this.PWInputField.MaxLength = 32767;
            this.PWInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWInputField.Name = "PWInputField";
            this.PWInputField.PasswordChar = '\0';
            this.PWInputField.SelectedText = "";
            this.PWInputField.SelectionLength = 0;
            this.PWInputField.SelectionStart = 0;
            this.PWInputField.Size = new System.Drawing.Size(75, 28);
            this.PWInputField.TabIndex = 1;
            this.PWInputField.TabStop = false;
            this.PWInputField.Text = "PW";
            this.PWInputField.UseSystemPasswordChar = false;
            // 
            // PWCMPInputField
            // 
            this.PWCMPInputField.Depth = 0;
            this.PWCMPInputField.Hint = "";
            this.PWCMPInputField.Location = new System.Drawing.Point(13, 154);
            this.PWCMPInputField.MaxLength = 32767;
            this.PWCMPInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWCMPInputField.Name = "PWCMPInputField";
            this.PWCMPInputField.PasswordChar = '\0';
            this.PWCMPInputField.SelectedText = "";
            this.PWCMPInputField.SelectionLength = 0;
            this.PWCMPInputField.SelectionStart = 0;
            this.PWCMPInputField.Size = new System.Drawing.Size(75, 28);
            this.PWCMPInputField.TabIndex = 2;
            this.PWCMPInputField.TabStop = false;
            this.PWCMPInputField.Text = "PW CMP";
            this.PWCMPInputField.UseSystemPasswordChar = false;
            // 
            // ClassInputField
            // 
            this.ClassInputField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClassInputField.Depth = 0;
            this.ClassInputField.Enabled = false;
            this.ClassInputField.Hint = "";
            this.ClassInputField.Location = new System.Drawing.Point(250, 84);
            this.ClassInputField.MaxLength = 32767;
            this.ClassInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassInputField.Name = "ClassInputField";
            this.ClassInputField.PasswordChar = '\0';
            this.ClassInputField.SelectedText = "";
            this.ClassInputField.SelectionLength = 0;
            this.ClassInputField.SelectionStart = 0;
            this.ClassInputField.Size = new System.Drawing.Size(75, 28);
            this.ClassInputField.TabIndex = 3;
            this.ClassInputField.TabStop = false;
            this.ClassInputField.Text = "Class";
            this.ClassInputField.UseSystemPasswordChar = false;
            this.ClassInputField.Click += new System.EventHandler(this.ClassInputField_Click);
            // 
            // NameInputField
            // 
            this.NameInputField.Depth = 0;
            this.NameInputField.Hint = "";
            this.NameInputField.Location = new System.Drawing.Point(250, 123);
            this.NameInputField.MaxLength = 32767;
            this.NameInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameInputField.Name = "NameInputField";
            this.NameInputField.PasswordChar = '\0';
            this.NameInputField.SelectedText = "";
            this.NameInputField.SelectionLength = 0;
            this.NameInputField.SelectionStart = 0;
            this.NameInputField.Size = new System.Drawing.Size(75, 28);
            this.NameInputField.TabIndex = 4;
            this.NameInputField.TabStop = false;
            this.NameInputField.Text = "Name";
            this.NameInputField.UseSystemPasswordChar = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButton.Depth = 0;
            this.SubmitButton.Icon = null;
            this.SubmitButton.Location = new System.Drawing.Point(117, 295);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(85, 36);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 343);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NameInputField);
            this.Controls.Add(this.ClassInputField);
            this.Controls.Add(this.PWCMPInputField);
            this.Controls.Add(this.PWInputField);
            this.Controls.Add(this.IDInputField);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField IDInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField PWInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField PWCMPInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField ClassInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameInputField;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitButton;
    }
}