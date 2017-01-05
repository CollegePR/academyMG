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
            this.PWInputfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.IDInputfield = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.RegisterButton.Location = new System.Drawing.Point(131, 201);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(83, 36);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
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
            // PWInputfield
            // 
            this.PWInputfield.Depth = 0;
            this.PWInputfield.Hint = "Password";
            this.PWInputfield.Location = new System.Drawing.Point(33, 136);
            this.PWInputfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PWInputfield.MaxLength = 32767;
            this.PWInputfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWInputfield.Name = "PWInputfield";
            this.PWInputfield.PasswordChar = '*';
            this.PWInputfield.SelectedText = "";
            this.PWInputfield.SelectionLength = 0;
            this.PWInputfield.SelectionStart = 0;
            this.PWInputfield.Size = new System.Drawing.Size(181, 23);
            this.PWInputfield.TabIndex = 5;
            this.PWInputfield.TabStop = false;
            this.PWInputfield.UseSystemPasswordChar = false;
            // 
            // IDInputfield
            // 
            this.IDInputfield.Depth = 0;
            this.IDInputfield.Hint = "ID";
            this.IDInputfield.Location = new System.Drawing.Point(33, 88);
            this.IDInputfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDInputfield.MaxLength = 32767;
            this.IDInputfield.MouseState = MaterialSkin.MouseState.HOVER;
            this.IDInputfield.Name = "IDInputfield";
            this.IDInputfield.PasswordChar = '\0';
            this.IDInputfield.SelectedText = "";
            this.IDInputfield.SelectionLength = 0;
            this.IDInputfield.SelectionStart = 0;
            this.IDInputfield.Size = new System.Drawing.Size(181, 23);
            this.IDInputfield.TabIndex = 4;
            this.IDInputfield.TabStop = false;
            this.IDInputfield.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialLabel1.ForeColor = System.Drawing.Color.Red;
            this.materialLabel1.Location = new System.Drawing.Point(172, 110);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel1.Size = new System.Drawing.Size(0, 12);
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
            this.materialLabel2.Location = new System.Drawing.Point(100, 180);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel2.Size = new System.Drawing.Size(0, 19);
            this.materialLabel2.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 268);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PWInputfield);
            this.Controls.Add(this.IDInputfield);
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton RegisterButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField PWInputfield;
        private MaterialSkin.Controls.MaterialSingleLineTextField IDInputfield;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}