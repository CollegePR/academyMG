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
using MaterialSkinExample.LoginRegister;

namespace MaterialSkinExample
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void ClassInputField_Click(object sender, EventArgs e)
        {
            SelectClassForm SCF = new SelectClassForm();
            SCF.ShowDialog();
        }
    }
}
