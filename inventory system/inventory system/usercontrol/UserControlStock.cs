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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectStocksQuery = selectionQuery;

                using (SqlCommand selectStocksCommand = new SqlCommand(selectStocksQuery, connection))
                {
                    using (SqlDataReader reader = selectStocksCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productNumber = reader["Product_Number"].ToString();
                            string productName = reader["Product_Name"].ToString();
                            decimal sellingPrice = Convert.ToDecimal(reader["Selling_Price"]);
                            decimal costingPrice = Convert.ToDecimal(reader["Costing_Price"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);

                            dgvProducts.Rows.Add(productNumber, productName, sellingPrice, costingPrice, quantity);
                        }
                    }
                }
            }
        }

        private void UserControlStocks_Load(object sender, EventArgs e)
        {
            FillStocksDataInGridView("Select * from Stocks");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillStocksDataInGridView("Select * from Stocks");
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            string query = "Select * From Stocks where Product_Name like '%" + txtSearchProducts.Text + "%'";
            FillStocksDataInGridView(query);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
