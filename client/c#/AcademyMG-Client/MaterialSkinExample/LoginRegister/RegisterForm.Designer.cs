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
            this.NameInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ClassInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PWCMPInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PWInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.IDInputField = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.SubmitButton.Location = new System.Drawing.Point(221, 214);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Primary = true;
            this.SubmitButton.Size = new System.Drawing.Size(51, 36);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "가입";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // NameInputField
            // 
            this.NameInputField.Depth = 0;
            this.NameInputField.Hint = "이름";
            this.NameInputField.Location = new System.Drawing.Point(12, 97);
            this.NameInputField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameInputField.MaxLength = 32767;
            this.NameInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameInputField.Name = "NameInputField";
            this.NameInputField.PasswordChar = '\0';
            this.NameInputField.SelectedText = "";
            this.NameInputField.SelectionLength = 0;
            this.NameInputField.SelectionStart = 0;
            this.NameInputField.Size = new System.Drawing.Size(260, 23);
            this.NameInputField.TabIndex = 10;
            this.NameInputField.TabStop = false;
            this.NameInputField.UseSystemPasswordChar = false;
            // 
            // ClassInputField
            // 
            this.ClassInputField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClassInputField.Depth = 0;
            this.ClassInputField.Enabled = false;
            this.ClassInputField.Hint = "학급명";
            this.ClassInputField.Location = new System.Drawing.Point(12, 178);
            this.ClassInputField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassInputField.MaxLength = 32767;
            this.ClassInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassInputField.Name = "ClassInputField";
            this.ClassInputField.PasswordChar = '\0';
            this.ClassInputField.SelectedText = "";
            this.ClassInputField.SelectionLength = 0;
            this.ClassInputField.SelectionStart = 0;
            this.ClassInputField.Size = new System.Drawing.Size(260, 23);
            this.ClassInputField.TabIndex = 9;
            this.ClassInputField.TabStop = false;
            this.ClassInputField.UseSystemPasswordChar = false;
            // 
            // PWCMPInputField
            // 
            this.PWCMPInputField.Depth = 0;
            this.PWCMPInputField.Hint = "비밀번호확인";
            this.PWCMPInputField.Location = new System.Drawing.Point(12, 151);
            this.PWCMPInputField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PWCMPInputField.MaxLength = 32767;
            this.PWCMPInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWCMPInputField.Name = "PWCMPInputField";
            this.PWCMPInputField.PasswordChar = '\0';
            this.PWCMPInputField.SelectedText = "";
            this.PWCMPInputField.SelectionLength = 0;
            this.PWCMPInputField.SelectionStart = 0;
            this.PWCMPInputField.Size = new System.Drawing.Size(260, 23);
            this.PWCMPInputField.TabIndex = 8;
            this.PWCMPInputField.TabStop = false;
            this.PWCMPInputField.UseSystemPasswordChar = false;
            // 
            // PWInputField
            // 
            this.PWInputField.Depth = 0;
            this.PWInputField.Hint = "비밀번호";
            this.PWInputField.Location = new System.Drawing.Point(12, 124);
            this.PWInputField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PWInputField.MaxLength = 32767;
            this.PWInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWInputField.Name = "PWInputField";
            this.PWInputField.PasswordChar = '\0';
            this.PWInputField.SelectedText = "";
            this.PWInputField.SelectionLength = 0;
            this.PWInputField.SelectionStart = 0;
            this.PWInputField.Size = new System.Drawing.Size(260, 23);
            this.PWInputField.TabIndex = 7;
            this.PWInputField.TabStop = false;
            this.PWInputField.UseSystemPasswordChar = false;
            // 
            // IDInputField
            // 
            this.IDInputField.Depth = 0;
            this.IDInputField.Hint = "아이디";
            this.IDInputField.Location = new System.Drawing.Point(12, 70);
            this.IDInputField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDInputField.MaxLength = 32767;
            this.IDInputField.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDInputField.Name = "IDInputField";
            this.IDInputField.PasswordChar = '\0';
            this.IDInputField.SelectedText = "";
            this.IDInputField.SelectionLength = 0;
            this.IDInputField.SelectionStart = 0;
            this.IDInputField.Size = new System.Drawing.Size(260, 23);
            this.IDInputField.TabIndex = 6;
            this.IDInputField.TabStop = false;
            this.IDInputField.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(164, 214);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(51, 36);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "취소";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NameInputField);
            this.Controls.Add(this.ClassInputField);
            this.Controls.Add(this.PWCMPInputField);
            this.Controls.Add(this.PWInputField);
            this.Controls.Add(this.IDInputField);
            this.Name = "RegisterForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton SubmitButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField ClassInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField PWCMPInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField PWInputField;
        private MaterialSkin.Controls.MaterialSingleLineTextField IDInputField;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}