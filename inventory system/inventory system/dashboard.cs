using inventory_system.usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory_system
{
    public partial class dashboard : Form
    {
        bool sidebarExpand;
        public dashboard()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            userctrlProductPage1.Show();
            userctrlProductPage1.BringToFront();
        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnProductTypes_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            userctrlPurchaseOrder1.Show();
            userctrlPurchaseOrder1.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchaseReturn_Click(object sender, EventArgs e)
        {
            usercontrolPurchasereturn1.Show();
            usercontrolPurchasereturn1.BringToFront();

            usercontrolPurchasereturn2.Show();
            usercontrolPurchasereturn2.BringToFront();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            usercontrolSales1.Show();
            usercontrolSales1.BringToFront();
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            userontrolSaleReturn1.Show();
            userontrolSaleReturn1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {

            userctrldailysale1.Show();
            userctrldailysale1.BringToFront();
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            usermonthlysale1.Show();
            usermonthlysale1.BringToFront();
        }

        private void btnYearlySales_Click(object sender, EventArgs e)
        {
            useryearlysale1.Show();
            useryearlysale1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            label1.Show();
            label1.BringToFront();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            siderbarTimer.Start();
        }

        private void siderbarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    siderbarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    siderbarTimer.Stop();
                }
            }
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            userctrlanalysis1.Show();
            userctrlanalysis1.BringToFront();
        }
        //public void ShowAddProduct()
        //{
        //    userControlAddproduct1.Show();
        //    userControlAddproduct1.BringToFront();
        //}
    }
}
