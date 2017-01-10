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

namespace MaterialSkinExample.DateSelect
{
    public partial class DateSelectForm : MaterialForm
    {
        public string SelectedDate;

        public DateSelectForm()
        {
            InitializeComponent();
            SelectedDate = null;
        }

        private void rb_dateselect_submit_Click(object sender, EventArgs e)
        {
            string Year = tf_dateselect_year.Text;
            string Month = tf_dateselect_month.Text;
            string Date = tf_dateselect_date.Text;

            SelectedDate = Year + "-" + Month + "-" + Date;

            this.Close();
        }
    }
}
