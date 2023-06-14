using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.usercontrol
{
    public partial class userctrlProductPage : UserControl
    {
        public userctrlProductPage()
        {
            InitializeComponent();
        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UserControlAddproduct obj = new UserControlAddproduct();
            obj.Show();
        }
    }
}
