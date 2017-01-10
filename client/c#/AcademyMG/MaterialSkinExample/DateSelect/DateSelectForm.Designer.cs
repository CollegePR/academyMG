namespace MaterialSkinExample.DateSelect
{
    partial class DateSelectForm
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
            this.tf_dateselect_year = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_dateselect_month = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tf_dateselect_date = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rb_dateselect_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tf_dateselect_year
            // 
            this.tf_dateselect_year.Depth = 0;
            this.tf_dateselect_year.Hint = "년";
            this.tf_dateselect_year.Location = new System.Drawing.Point(12, 141);
            this.tf_dateselect_year.MaxLength = 32767;
            this.tf_dateselect_year.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_dateselect_year.Name = "tf_dateselect_year";
            this.tf_dateselect_year.PasswordChar = '\0';
            this.tf_dateselect_year.SelectedText = "";
            this.tf_dateselect_year.SelectionLength = 0;
            this.tf_dateselect_year.SelectionStart = 0;
            this.tf_dateselect_year.Size = new System.Drawing.Size(79, 28);
            this.tf_dateselect_year.TabIndex = 0;
            this.tf_dateselect_year.TabStop = false;
            this.tf_dateselect_year.UseSystemPasswordChar = false;
            // 
            // tf_dateselect_month
            // 
            this.tf_dateselect_month.Depth = 0;
            this.tf_dateselect_month.Hint = "월";
            this.tf_dateselect_month.Location = new System.Drawing.Point(97, 141);
            this.tf_dateselect_month.MaxLength = 32767;
            this.tf_dateselect_month.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_dateselect_month.Name = "tf_dateselect_month";
            this.tf_dateselect_month.PasswordChar = '\0';
            this.tf_dateselect_month.SelectedText = "";
            this.tf_dateselect_month.SelectionLength = 0;
            this.tf_dateselect_month.SelectionStart = 0;
            this.tf_dateselect_month.Size = new System.Drawing.Size(75, 28);
            this.tf_dateselect_month.TabIndex = 1;
            this.tf_dateselect_month.TabStop = false;
            this.tf_dateselect_month.UseSystemPasswordChar = false;
            // 
            // tf_dateselect_date
            // 
            this.tf_dateselect_date.Depth = 0;
            this.tf_dateselect_date.Hint = "일";
            this.tf_dateselect_date.Location = new System.Drawing.Point(178, 141);
            this.tf_dateselect_date.MaxLength = 32767;
            this.tf_dateselect_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_dateselect_date.Name = "tf_dateselect_date";
            this.tf_dateselect_date.PasswordChar = '\0';
            this.tf_dateselect_date.SelectedText = "";
            this.tf_dateselect_date.SelectionLength = 0;
            this.tf_dateselect_date.SelectionStart = 0;
            this.tf_dateselect_date.Size = new System.Drawing.Size(92, 28);
            this.tf_dateselect_date.TabIndex = 2;
            this.tf_dateselect_date.TabStop = false;
            this.tf_dateselect_date.UseSystemPasswordChar = false;
            // 
            // rb_dateselect_submit
            // 
            this.rb_dateselect_submit.AutoSize = true;
            this.rb_dateselect_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rb_dateselect_submit.Depth = 0;
            this.rb_dateselect_submit.Icon = null;
            this.rb_dateselect_submit.Location = new System.Drawing.Point(97, 205);
            this.rb_dateselect_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_dateselect_submit.Name = "rb_dateselect_submit";
            this.rb_dateselect_submit.Primary = true;
            this.rb_dateselect_submit.Size = new System.Drawing.Size(85, 36);
            this.rb_dateselect_submit.TabIndex = 3;
            this.rb_dateselect_submit.Text = "Submit";
            this.rb_dateselect_submit.UseVisualStyleBackColor = true;
            this.rb_dateselect_submit.Click += new System.EventHandler(this.rb_dateselect_submit_Click);
            // 
            // DateSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.rb_dateselect_submit);
            this.Controls.Add(this.tf_dateselect_date);
            this.Controls.Add(this.tf_dateselect_month);
            this.Controls.Add(this.tf_dateselect_year);
            this.Name = "DateSelectForm";
            this.Text = "DateSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tf_dateselect_year;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_dateselect_month;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_dateselect_date;
        private MaterialSkin.Controls.MaterialRaisedButton rb_dateselect_submit;
    }
}