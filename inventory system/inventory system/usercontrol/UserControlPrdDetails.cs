using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace inventory_system.usercontrol
{
    public partial class UserControlPrdDetails : UserControl
    {
        private Image selectedImage = null;

        // Public properties to store the data
        public int ProductID { get; set; }
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryID { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductCategoryDescription { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal CostingPrice { get; set; }
        public int Quantity { get; set; }
        public Image ProductImage { get; set; }

        public UserControlPrdDetails()
        {
            InitializeComponent();
        }

        private void SetDataToControls()
        {
            pictureBox1.Image = ProductImage;
            lblCategory.Text = ProductCategoryName;
            txtProductName.Text = ProductName;
            lblCategory.Text = ProductCategoryName;
            txtDescription.Text = ProductCategoryDescription;
            txtBoxSellingPrice.Text = SellingPrice.ToString() + ".00";
            txtBoxCostingPrice.Text = CostingPrice.ToString() + ".00";
            numericUpDown1.Value = 1;
            numericUpDown1.Maximum = Quantity;
            numericUpDown1.Minimum = 1;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Handle numeric up-down value change if needed
        }

        private void UserControlPrdDetails_Load(object sender, EventArgs e)
        {
            SetDataToControls();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = (int)numericUpDown1.Value;
                decimal unitPrice = decimal.Parse(txtBoxSellingPrice.Text);
                decimal subTotal = quantity * unitPrice;

                using (SqlConnection connection = new SqlConnection("Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True"))
                {
                    connection.Open();

                    // Check if the product already exists in the cart
                    string selectQuery = "SELECT COUNT(*) FROM tblCart WHERE Product_Number = @ProductNumber";
                    using (SqlCommand checkCmd = new SqlCommand(selectQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductNumber", ProductNumber);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            // Update the quantity for the existing product
                            string updateQuery = "UPDATE tblCart SET Quantity = Quantity + @Quantity WHERE Product_Number = @ProductNumber";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@ProductNumber", ProductNumber);
                                updateCmd.ExecuteNonQuery();
                            }

                            // Recalculate and update the Sub_Total value for the existing product
                            string updateSubTotalQuery = "UPDATE tblCart SET Sub_Total = Quantity * Unit_Price WHERE Product_Number = @ProductNumber";
                            using (SqlCommand updateSubTotalCmd = new SqlCommand(updateSubTotalQuery, connection))
                            {
                                updateSubTotalCmd.Parameters.AddWithValue("@ProductNumber", ProductNumber);
                                updateSubTotalCmd.ExecuteNonQuery();
                            }
                        }

                        else
                        {
                            // Insert the new product into the cart
                            string insertQuery = "INSERT INTO tblCart (Product_Number, Product_Name, Quantity, Unit_Price, Sub_Total) VALUES (@ProductNumber, @ProductName, @Quantity, @UnitPrice, @SubTotal)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@ProductNumber", ProductNumber);
                                insertCmd.Parameters.AddWithValue("@ProductName", ProductName);
                                insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                insertCmd.Parameters.AddWithValue("@SubTotal", subTotal);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Item added to cart successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
