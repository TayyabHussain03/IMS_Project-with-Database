using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventory_system.usercontrol
{
    public partial class UserControlInvoiceDetails : UserControl
    {
        public UserControlInvoiceDetails(string Date, int Invoice, int Total)
        {
            InitializeComponent();
            //this.CurrntDate = Date;
            //this.InvoiceNO = Invoice;
            //this.TotalPrice = Total;
        }

        private void UserControlInvoiceDetails_Load(object sender, EventArgs e)
        {
            //lblDate.Text = "Current Date : " + CurrntDate;
            //lblInv.Text = "Invoice Number : " + InvoiceNO;
            //lblTotal.Text = "Total AMount : " + TotalPrice;
        }
        private void btnAddCtg_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvInvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
        }

        private void lblInv_Click(object sender, EventArgs e)
        {
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }
    }
}
