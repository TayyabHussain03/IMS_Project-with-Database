using System.Data;
using System.Data.SqlClient;

namespace inventory_system.usercontrol
{
    public partial class UserControlStock : UserControl
    {
        public UserControlStock()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";

        private void FillStocksDataInGridView(string selectionQuery)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(selectionQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            FillStocksDataInGridView("Select * from Stocks");
        }

        private void btnSearchProducts_Click_1(object sender, EventArgs e)
        {
            string query = "Select * From Stocks where Product_Name like '%" + txtSearchProducts.Text + "%'";
            FillStocksDataInGridView(query);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            string query = "Select * From Stocks where Product_Name like '%" + txtSearchProducts.Text + "%'";
            FillStocksDataInGridView(query);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedProductNumber = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Product_Number"].Value);

                    // Delete the record from the database
                    SqlConnection con = new SqlConnection(connectionString);
                    string deleteQuery = "DELETE FROM Stocks WHERE Product_Number = @ProductNumber";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductNumber", selectedProductNumber);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    // Remove the selected row from the DataGridView
                    dgvProducts.Rows.RemoveAt(dgvProducts.SelectedRows[0].Index);

                    MessageBox.Show("Product deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }
    }
}
