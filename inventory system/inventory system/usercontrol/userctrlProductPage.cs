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
            addproduct.ShowDialog();
        }
        private void RefreshGrid(string query)
        {
            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
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
                    SqlConnection con = new SqlConnection("Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True");
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

            SqlConnection con = new SqlConnection("Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products_Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row["Product_Category_ID"] = 0;
            row["Category_Name"] = "Please Select";
            dt.Rows.InsertAt(row, 0);

            cmbCategoryFilter.DataSource = dt;
            cmbCategoryFilter.DisplayMember = "Category_Name";
            cmbCategoryFilter.ValueMember = "Product_Category_ID";
            cmbCategoryFilter.KeyPress += CmbCategoryFilter_KeyPress;
            btnDelete.Click += btnDelete_Click;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;

            btnEdit.Click += btnEdit_Click;
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
                SqlConnection con = new SqlConnection("Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True");

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
                using (SqlConnection con = new SqlConnection("Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True"))
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
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
