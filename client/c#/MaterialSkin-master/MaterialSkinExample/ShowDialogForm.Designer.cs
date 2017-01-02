namespace MaterialSkinExample
{
    partial class ShowDialogForm
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
            this.DialogText = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // DialogText
            // 
            this.DialogText.AutoSize = true;
            this.DialogText.Depth = 0;
            this.DialogText.Font = new System.Drawing.Font("Roboto", 11F);
            this.DialogText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DialogText.Location = new System.Drawing.Point(12, 82);
            this.DialogText.MouseState = MaterialSkin.MouseState.HOVER;
            this.DialogText.Name = "DialogText";
            this.DialogText.Size = new System.Drawing.Size(146, 24);
            this.DialogText.TabIndex = 0;
            this.DialogText.Text = "ShowDialogText";
            this.DialogText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.DialogText);
            this.Name = "ShowDialogForm";
            this.Text = "DialogName";
            this.Load += new System.EventHandler(this.ShowDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel DialogText;

    }
}