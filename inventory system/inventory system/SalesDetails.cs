using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class SalesDetails : Form
    {
        private string CurrntDate;
        private string CurrntTime;
        private int InvoiceNO;
        private decimal TotalPrice;
        public SalesDetails(string Date, string Time, int Invoice, decimal Total)
        {
            InitializeComponent();
            this.CurrntDate = Date;
            this.CurrntTime = Time;
            this.InvoiceNO = Invoice;
            this.TotalPrice = Total;
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Current Date : " + CurrntDate;
            lblTime.Text = "Current Time  : " + CurrntTime;
            lblInv.Text = "Invoice Number : " + InvoiceNO;
            lblTotal.Text = "Total AMount : " + TotalPrice;
        }
        private void btnAddCtg_Click(object sender, EventArgs e)
        {

        }

    }
}
