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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool LoginSuccess = false;
            string ID = IDInputfield.Text;
            string PW = PWInputfield.Text;
            Util.ShowInDialog("Test","ID : " + ID + "\nPW : " + PW);
            //서버

            LoginSuccess = true;

            if (LoginSuccess == true) {
                MainForm MainScreen = new MainForm();
                MainScreen.Show();
                this.Close();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form Register = new RegisterForm();
            Register.ShowDialog();
            //Util.Notification("알림","Test");
        }
    }
}
