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
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();

            InitializeListView();
        }

        private async void InitializeListView()
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };
            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);
            var result = await service.AccessList();

            if (result.flag)
            {
                foreach(AccessListSubData access_list_data in result.data){
                    var data = new[] { access_list_data.id, access_list_data.name, access_list_data.academy_class.ToString() };
                    var item = new ListViewItem(data);
                    materialListView1.Items.Add(item);
                }
            }
            else
            {
                var data = new []{ "NULL", "NULL", "NULL" };
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
                var admission_data = new AdmissionStatusData
                {
                    id = materialListView1.SelectedItems[0].Text,
                    status = 2
                };
                var result = await service.AdmissionStatus(admission_data);

                if (result.flag) materialListView1.Items.Remove(materialListView1.SelectedItems[0]);
            }
        }
    }
}
