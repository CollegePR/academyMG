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
        static string key;
        static int id;
        public Form1(string num)
        {
            InitializeComponent();

            key = num;

            InitializeListView();

        }

        private async void InitializeListView()
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };
            var service = RestService.For<AcademyMG_APIs>("http://127.0.0.1:5013", settings);

            var result = await service.Search(key);

            if (result.flag)
            {
                foreach (SearchSubData searchsubData in result.data)
                {
                    var result2 = await service.Search(key);
                    var data = new[] { Convert.ToString(searchsubData.id), searchsubData.name,
                        Convert.ToString(searchsubData.academy_class), searchsubData.phone_num,
                        searchsubData.address,searchsubData.school_name, Convert.ToString(searchsubData.grade),
                        Convert.ToString(searchsubData.school_class), searchsubData.date_of_admission,
                        searchsubData.date_of_readdmission, searchsubData.date_of_exit, searchsubData.birthday};

                    var item = new ListViewItem(data);
                    materialListView1.Items.Add(item);
                }
            }
            else
            {
                var data = new[] { "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL" };
                var item = new ListViewItem(data);
                materialListView1.Items.Add(item);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {

                id = int.Parse(materialListView1.SelectedItems[0].Text);

                MainForm mainform = new MainForm(id);
                this.Hide();
                //mainform.ShowDialog();
            }
        }
    }
}