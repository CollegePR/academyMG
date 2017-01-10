namespace MaterialSkinExample.ShowDialog
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
            this.lb_showdialog_text = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lb_showdialog_text
            // 
            this.lb_showdialog_text.AutoSize = true;
            this.lb_showdialog_text.Depth = 0;
            this.lb_showdialog_text.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_showdialog_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_showdialog_text.Location = new System.Drawing.Point(100, 141);
            this.lb_showdialog_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_showdialog_text.Name = "lb_showdialog_text";
            this.lb_showdialog_text.Size = new System.Drawing.Size(64, 24);
            this.lb_showdialog_text.TabIndex = 0;
            this.lb_showdialog_text.Text = "Empty";
            // 
            // ShowDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lb_showdialog_text);
            this.Name = "ShowDialogForm";
            this.Text = "ShowDialogForm";
            this.Load += new System.EventHandler(this.ShowDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lb_showdialog_text;
    }
}