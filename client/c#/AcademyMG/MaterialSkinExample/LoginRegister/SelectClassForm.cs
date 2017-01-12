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

namespace MaterialSkinExample.LoginRegister
{
    public partial class SelectClassForm : MaterialForm
    {
        RegisterForm registerForm = null;
        MaterialSingleLineTextField tf = null;

        public SelectClassForm()
        {
            InitializeComponent();
        }

        public SelectClassForm(MaterialSingleLineTextField tf) : this()
        {
            this.tf = tf;
        }

        public SelectClassForm(RegisterForm registerForm) : this()
        {
            this.registerForm = registerForm;
        }

        public SelectClassForm(RegisterForm registerForm, MaterialSingleLineTextField tf) : this()
        {
            this.registerForm = registerForm;
            this.tf = tf;
        }

        private void SelectClassForm_Load(object sender, EventArgs e)
        {
            InitializationListView();
        }

        private async void InitializationListView()
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };
            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);
            var result = await service.GetClassList();

            if (result.flag)
            {
                foreach (ClassListSubData class_list_data in result.data)
                {
                    var data = new[] { class_list_data.id.ToString() ,class_list_data.name };
                    var item = new ListViewItem(data);
                    materialListView1.Items.Add(item);
                }
            }
            else
            {
                var data = new[] { "NULL", "NULL" };
                var item = new ListViewItem(data);
                materialListView1.Items.Add(item);
            }
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                var settings = new RefitSettings
                {
                    JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
                };
                var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);
                var result = await service.GetClassName(Int32.Parse(materialListView1.SelectedItems[0].Text));
                if (result.flag)
                {
                    if (registerForm != null) registerForm.class_id = Int32.Parse(materialListView1.SelectedItems[0].Text);
                    if (tf != null) tf.Text = result.data.name;
                    this.Close();
                }
            }
        }

        private void materialListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) materialRaisedButton1.PerformClick();
        }
    }
}
