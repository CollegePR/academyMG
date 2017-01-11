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
using RestSharp;
using MaterialSkinExample.Encrypter;
using System.Web;
using Refit;

using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Xunit;
using RichardSzalay.MockHttp;

using Refit.Tests;

namespace MaterialSkinExample
{
    public partial class Form1 : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        public Form1(string[] num)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            
            if (num[0] != null)
                materialLabel1.Text = num[0];

            if (num[1] != null)
                materialLabel2.Text = num[1];

            if (num[2] != null)
                materialLabel3.Text = num[2];

            if (num[3] != null)
                materialLabel4.Text = num[3];

            if (num[4] != null)
                materialLabel5.Text = num[4];

            if (num[5] != null)
                materialLabel6.Text = num[5];

            if (num[6] != null)
                materialLabel7.Text = num[6];
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            new MainForm(0);
            this.Close();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            new MainForm(1);
            this.Close();
        }
        private void materialLabel3_Click(object sender, EventArgs e)
        {
            new MainForm(2);
            this.Close();
        }
        private void materialLabel4_Click(object sender, EventArgs e)
        {
            new MainForm(3);
            this.Close();
        }
        private void materialLabel5_Click(object sender, EventArgs e)
        {
            new MainForm(4);
            this.Close();
        }
        private void materialLabel6_Click(object sender, EventArgs e)
        {
            new MainForm(5);
            this.Close();
        }
        private void materialLabel7_Click(object sender, EventArgs e)
        {
            new MainForm(6);
            this.Close();
        }
    }
}
