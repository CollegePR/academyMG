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

namespace MaterialSkinExample.LoginRegister
{
    public partial class SelectClassForm : MaterialForm
    {
        private int ElementNum;
        List<MaterialRaisedButton> Elements = new List<MaterialRaisedButton>();
        
        public SelectClassForm()
        {
            ElementNum = 3; //서버에서 받아와야됨
            InitializeComponent();
        }

        private void SelectClassForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ElementNum; i++)
            {
                MaterialRaisedButton Element = new MaterialRaisedButton();
                
                Elements.Add(Element);
            }
        }

    }
}
