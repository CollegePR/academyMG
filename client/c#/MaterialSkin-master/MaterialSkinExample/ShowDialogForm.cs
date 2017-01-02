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

namespace MaterialSkinExample
{
    public partial class ShowDialogForm : MaterialForm
    {
        public ShowDialogForm()
        {
            this.Name = "Test";
            InitializeComponent();
        }

        public ShowDialogForm(string Name,string Text)
        {
            InitializeComponent();
            this.Name = Name;
            DialogText.Text = Text;
        }

        public void SetNameText(string Name,string Text){
            this.Text = Name;
            DialogText.Text = Text;
        }

        private void ShowDialogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
