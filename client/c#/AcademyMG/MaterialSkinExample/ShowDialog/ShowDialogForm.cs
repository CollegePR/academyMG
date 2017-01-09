using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample.ShowDialog
{
    public partial class ShowDialogForm : MaterialForm
    {
        string DefaultTitle = "Test";

        public ShowDialogForm()
        {
            InitializeComponent();
            this.Text = DefaultTitle;
        }

        public ShowDialogForm(string Text)
        {
            InitializeComponent();
            this.Text = DefaultTitle;
            lb_showdialog_text.Text = Text;
        }

        public ShowDialogForm(string Title, string Text)
        {
            InitializeComponent();
            this.Text = Title;
            lb_showdialog_text.Text = Text;
        }

        public void SetTitleText(string Title, string Text)
        {
            this.Text = Title;
            lb_showdialog_text.Text = Text;
        }

        private void ShowDialogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
