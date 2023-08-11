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
    public partial class userctrlProductPage : UserControl
    {
        private const string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";

        public userctrlProductPage()
        {
            InitializeComponent();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form addproduct = new Form();
            UserControlAddproduct usaddproduct = new UserControlAddproduct();
            usaddproduct.Dock = DockStyle.Fill;
            addproduct.Controls.Add(usaddproduct);
            addproduct.Size = new Size(762, 660);
            addproduct.StartPosition = FormStartPosition.CenterScreen;
            addproduct.ShowDialog();
        }
        private void RefreshGrid(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProducts.Columns.Clear();

            dgvProducts.DataSource = dt;

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.HeaderText = "View";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;

            viewButtonColumn.Width = 70;

            dgvProducts.Columns.Add(viewButtonColumn);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedProductId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);

                    // Delete the record from the database
                    SqlConnection con = new SqlConnection(connectionString);
                    string deleteQuery = "DELETE FROM Products WHERE Product_ID = @ProductId";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", selectedProductId);
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
        private void userctrlProductPage_Load(object sender, EventArgs e)
        {
            string QRY = "SELECT Products.Product_ID as ID, Products.Product_Name as Name, Products_Category.Category_Name, Products.Selling_Price, Products.Costing_Price, Products.Quantity FROM Products JOIN Products_Category ON Products.Product_Category_ID = Products_Category.Product_Category_ID order by Products.Product_ID desc";
            RefreshGrid(QRY);

            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products_Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row["Product_Category_ID"] = 0;
            row["Category_Name"] = "All Products";
            dt.Rows.InsertAt(row, 0);

            cmbCategoryFilter.DataSource = dt;
            cmbCategoryFilter.DisplayMember = "Category_Name";
            cmbCategoryFilter.ValueMember = "Product_Category_ID";
            cmbCategoryFilter.KeyPress += CmbCategoryFilter_KeyPress;
            btnDelete.Click += btnDelete_Click;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;

            btnEdit.Click += btnEdit_Click;
            dgvProducts.CellClick += dgvProducts_CellClick;
        }
        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                // Enable the "Edit" button when a row is selected
                btnEdit.Enabled = true;
            }
            else
            {
                // Disable the "Edit" button when no row is selected
                btnEdit.Enabled = false;
            }
        }
        private void CmbCategoryFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cancel any keypress to prevent manual input
            e.Handled = true;
        }
        private void btnCtgPage_Click(object sender, EventArgs e)
        {

            Form addcategory = new Form();
            usercontrolAddCtg usaddproduct = new usercontrolAddCtg();
            usaddproduct.Dock = DockStyle.Fill;
            addcategory.Controls.Add(usaddproduct);
            addcategory.Size = new Size(762, 660);
            addcategory.StartPosition = FormStartPosition.CenterScreen;
            addcategory.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT Products.Product_ID as ID, Products.Product_Name as Name, Products_Category.Category_Name, Products.Selling_Price, Products.Costing_Price, Products.Quantity FROM Products JOIN Products_Category ON Products.Product_Category_ID = Products_Category.Product_Category_ID order by Products.Product_ID desc";
            RefreshGrid(query);
        }
        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            string query = "Select * From Products where Product_Name like '%" + txtSearchProducts.Text + "%'";
            RefreshGrid(query);
            txtSearchProducts.Text = "";
        }
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryFilter.SelectedIndex == 0)
            {
                string query = "SELECT Products.Product_ID as ID, Products.Product_Name as Name, Products_Category.Category_Name, Products.Selling_Price, Products.Costing_Price, Products.Quantity FROM Products JOIN Products_Category ON Products.Product_Category_ID = Products_Category.Product_Category_ID order by Products.Product_ID desc";
                RefreshGrid(query);
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query = "SELECT Products.Product_ID as ID, Products.Product_Name as Name, Products_Category.Category_Name, Products.Selling_Price, Products.Costing_Price, Products.Quantity FROM Products JOIN Products_Category ON Products.Product_Category_ID = Products_Category.Product_Category_ID WHERE Products_Category.Category_Name LIKE '%" + cmbCategoryFilter.Text.ToString() + "%' order by Products.Product_ID desc";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);

                // Assuming you have the connection established.
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string QRY = "SELECT Product_ID, Product_Number, Product_Name, Selling_Price, Costing_Price, Quantity, Image FROM Products WHERE Product_ID = @ProductID";
                    SqlCommand cmd = new SqlCommand(QRY, con);
                    cmd.Parameters.AddWithValue("@ProductID", selectedProductId);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int productId = Convert.ToInt32(reader["Product_ID"]);
                            int productNumber = Convert.ToInt32(reader["Product_Number"]);
                            string productName = reader["Product_Name"].ToString();
                            decimal sellingPrice = Convert.ToDecimal(reader["Selling_Price"]);
                            decimal costingPrice = Convert.ToDecimal(reader["Costing_Price"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            byte[] imageData = (byte[])reader["Image"];
                            Image productImage = ConvertByteArrayToImage(imageData);


                            usercontrolEditPrd editProductControl = new usercontrolEditPrd();

                            editProductControl.ProductID = productId;
                            editProductControl.ProductNumber = productNumber;
                            editProductControl.ProductName = productName;
                            editProductControl.SellingPrice = sellingPrice;
                            editProductControl.CostingPrice = costingPrice;
                            editProductControl.Quantity = quantity;
                            editProductControl.ProductImage = productImage;

                            Form editproduct = new Form();
                            editproduct.Controls.Add(editProductControl);
                            editProductControl.Dock = DockStyle.Fill;
                            editproduct.Size = new Size(762, 660);
                            editproduct.StartPosition = FormStartPosition.CenterScreen;
                            editproduct.ShowDialog();
                        }
                    }
                }
            }
        }
        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is of type DataGridViewButtonCell
            if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count &&
                e.ColumnIndex >= 0 && e.ColumnIndex < dgvProducts.Columns.Count)
            {
                DataGridViewCell clickedCell = dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the clicked cell is the "View" button cell
                if (clickedCell is DataGridViewButtonCell buttonCell && buttonCell.Value != null &&
                    buttonCell.Value.ToString() == "View")
                {

                    int selectedProductId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ID"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string productQuery = "SELECT Product_ID, Product_Number, Product_Name, Product_Category_ID, Selling_Price, Costing_Price, Quantity, Image FROM Products WHERE Product_ID = @ProductID";
                        SqlCommand productCmd = new SqlCommand(productQuery, con);
                        productCmd.Parameters.AddWithValue("@ProductID", selectedProductId);
                        con.Open();

                        using (SqlDataReader productReader = productCmd.ExecuteReader())
                        {
                            if (productReader.Read())
                            {
                                int productId = Convert.ToInt32(productReader["Product_ID"]);
                                int productNumber = Convert.ToInt32(productReader["Product_Number"]);
                                string productName = productReader["Product_Name"].ToString();
                                int productCategoryId = Convert.ToInt32(productReader["Product_Category_ID"]);
                                decimal sellingPrice = Convert.ToDecimal(productReader["Selling_Price"]);
                                decimal costingPrice = Convert.ToDecimal(productReader["Costing_Price"]);
                                int quantity = Convert.ToInt32(productReader["Quantity"]);
                                byte[] imageData = (byte[])productReader["Image"];
                                Image productImage = ConvertByteArrayToImage(imageData);

                                // Close the first DataReader before executing the second query
                                productReader.Close();

                                // Fetch category information using the Product_Category_ID
                                string categoryQuery = "SELECT Category_Name, Description FROM Products_Category WHERE Product_Category_ID = @CategoryID";
                                SqlCommand categoryCmd = new SqlCommand(categoryQuery, con);
                                categoryCmd.Parameters.AddWithValue("@CategoryID", productCategoryId);

                                using (SqlDataReader categoryReader = categoryCmd.ExecuteReader())
                                {
                                    if (categoryReader.Read())
                                    {
                                        string categoryName = categoryReader["Category_Name"].ToString();
                                        string categoryDescription = categoryReader["Description"].ToString();


                                        UserControlPrdDetails usPrdDetails = new UserControlPrdDetails();

                                        usPrdDetails.ProductID = productId;
                                        usPrdDetails.ProductNumber = productNumber;
                                        usPrdDetails.ProductName = productName;
                                        usPrdDetails.ProductCategoryID = productCategoryId;
                                        usPrdDetails.ProductCategoryName = categoryName;
                                        usPrdDetails.ProductCategoryDescription = categoryDescription;
                                        usPrdDetails.SellingPrice = sellingPrice;
                                        usPrdDetails.CostingPrice = costingPrice;
                                        usPrdDetails.Quantity = quantity;
                                        usPrdDetails.ProductImage = productImage;

                                        Form prdDetails = new Form();
                                        usPrdDetails.Dock = DockStyle.Fill;
                                        prdDetails.Controls.Add(usPrdDetails);
                                        prdDetails.Size = new Size(830, 485);
                                        prdDetails.StartPosition = FormStartPosition.CenterScreen;
                                        prdDetails.ShowDialog();
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchProducts_Click_1(object sender, EventArgs e)
        {
            string query = "Select * From Products where Product_Name like '%" + txtSearchProducts.Text + "%'";
            RefreshGrid(query);
            txtSearchProducts.Text = "";
        }

        private void cmbCategoryFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCategoryFilter.SelectedIndex == 0)
            {
                string query = "SELECT Products.Product_ID as ID, Products.Product_Name as Name, Products_Category.Category_Name, Products.Selling_Price, Products.Costing_Price, Products.Quantity FROM Products JOIN Products_Category ON Products.Product_Category_ID = Products_Category.Product_Category_ID order by Products.Product_ID desc";
                RefreshGrid(query);
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query = "SELECT Products.Product_ID as ID, Products.Product_Name as Name, Products_Category.Category_Name, Products.Selling_Price, Products.Costing_Price, Products.Quantity FROM Products JOIN Products_Category ON Products.Product_Category_ID = Products_Category.Product_Category_ID WHERE Products_Category.Category_Name LIKE '%" + cmbCategoryFilter.Text.ToString() + "%' order by Products.Product_ID desc";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }
    }
}
