using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.usercontrol
{
    public partial class userontrolSaleReturn : UserControl
    {
        private const string connectionString = "Data Source=DESKTOP-RRIV42K\\SQLEXPRESS;Initial Catalog=dbIMS-1;Integrated Security=True";
        public userontrolSaleReturn()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (prdnumb.Text == "" || custname.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("Fill all the field ");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertSaleQuery = "Insert into Sales_Return (Sales_Return_Date, Reason,Sales_Return_Amount, unit_price, quantity, Product_Number, Customer_Name) Values (@date, @reason, @total, @price, @quantity, @product_id, @custname); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(insertSaleQuery, connection))
                    {
                        command.Parameters.AddWithValue("@product_id", Convert.ToInt32(prdnumb.Text));
                        command.Parameters.AddWithValue("@quantity", Convert.ToInt32(prdqty.Text));
                        command.Parameters.AddWithValue("@price", Convert.ToInt32(prdprice.Text));
                        command.Parameters.AddWithValue("@total", (Convert.ToDecimal(prdqty.Text) * Convert.ToInt32(prdprice.Text)));
                        command.Parameters.AddWithValue("@custname", custname.Text);
                        command.Parameters.AddWithValue("@reason", reason.Text);
                        command.Parameters.AddWithValue("@date", date.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.ExecuteNonQuery();

                        string updateProductQuery = "UPDATE Products SET Quantity = Quantity + @quantity WHERE Product_Number = @product_id";
                        using (SqlCommand updateCommand = new SqlCommand(updateProductQuery, connection))
                        {
                            command.Parameters.AddWithValue("@product_id", Convert.ToInt32(prdnumb.Text));
                            command.Parameters.AddWithValue("@quantity", Convert.ToInt32(prdqty.Text));
                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Inventory Updated.");
                        }
                    }
                    //    string QRY = "Insert into Sales_Return (Sales_Return_Date, Reason,Sales_Return_Amount, unit_price, quantity, Product_Number, Customer_Name) Values ('" + date.Value + "','" + reason.Text + "','" +  prdtotal.Text + "','" + Convert.ToInt32(prdprice.Text) + "','" + Convert.ToInt32(prdqty.Text) + "','" + Convert.ToInt32(prdnumb.Text) + "','" + custname.Text + "')";

                    //SqlCommand cmd = new SqlCommand(QRY, con);

                    //con.Open();
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                    //MessageBox.Show("Inventory Updated");

                    prdnumb.Text = "";
                    prdprice.Text = "";
                    prdqty.Text = "";
                    prdtotal.Text = "";
                    reason.Text = "";
                    custname.Text = "";
                }
            }
        }
    }
}
