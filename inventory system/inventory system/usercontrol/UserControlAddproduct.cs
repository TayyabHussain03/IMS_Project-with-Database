using inventory_system.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace inventory_system.usercontrol
{
    public partial class UserControlAddproduct : UserControl
    {
        // Declare a variable to store the selected image
        private Image selectedImage = null;

        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";

        public UserControlAddproduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtCostingPrice.Text == "" || txtproductName.Text == "" || txtproductNumber.Text == "" || txtSellingPrice.Text == "" || txtProductQuantity.Text == "")
            {
                MessageBox.Show("Fill All Field");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                string productNumber = txtproductNumber.Text;
                string productName = txtproductName.Text;
                decimal costingPrice = Convert.ToDecimal(txtCostingPrice.Text);
                decimal sellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
                int enteredQuantity = Convert.ToInt32(txtProductQuantity.Text);

                if (cmbproductCategory.SelectedItem != null)
                {
                    DataRowView selectedCategory = (DataRowView)cmbproductCategory.SelectedItem;
                    int categoryId = Convert.ToInt32(selectedCategory["Product_Category_ID"]);

                    // Check if the entered quantity is valid
                    if (enteredQuantity > retrievedQuantity)
                    {
                        MessageBox.Show($"Only {retrievedQuantity} products available in stock.");
                    }
                    else
                    {
                        string QRY = "INSERT INTO Products (Product_Number, Product_Name, Product_Category_ID, Costing_Price, Selling_Price, Quantity, Image) VALUES (@ProductNumber, @ProductName, @CategoryId, @CostingPrice, @SellingPrice, @Quantity, @Image)";

                        using (SqlCommand cmd = new SqlCommand(QRY, con))
                        {
                            cmd.Parameters.AddWithValue("@ProductNumber", productNumber);
                            cmd.Parameters.AddWithValue("@ProductName", productName);
                            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                            cmd.Parameters.AddWithValue("@CostingPrice", costingPrice);
                            cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                            cmd.Parameters.AddWithValue("@Quantity", enteredQuantity);

                            // Use the selected image if available, otherwise save the current image
                            if (selectedImage != null)
                            {
                                cmd.Parameters.AddWithValue("@Image", SavePhoto(selectedImage));
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@Image", SavePhoto(pictureBox1.Image));
                            }

                            con.Open();
                            cmd.ExecuteNonQuery();

                            // Subtract the entered quantity from the stock quantity in the Stocks table
                            string updateStockQuery = "UPDATE Stocks SET Quantity = Quantity - @Quantity WHERE Product_Number = @ProductNumber";
                            using (SqlCommand updateCmd = new SqlCommand(updateStockQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@ProductNumber", productNumber);
                                updateCmd.Parameters.AddWithValue("@Quantity", enteredQuantity); // Use entered quantity
                                updateCmd.ExecuteNonQuery();
                            }

                            con.Close();

                            txtproductNumber.Text = "";
                            txtproductName.Text = "";
                            txtCostingPrice.Text = "";
                            txtSellingPrice.Text = "";
                            txtProductQuantity.Text = "";
                            pictureBox1.Image = Resources.no_image;

                            MessageBox.Show("Product Added Successfully");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category.");
                }
            }
        }



        private byte[] SavePhoto(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.GetBuffer();
        }

        private void UserControlAddproduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products_Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbproductCategory.DataSource = dt;
            cmbproductCategory.DisplayMember = "Category_Name";
            cmbproductCategory.ValueMember = "Product_Category_ID";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.jpeg) | *.png;*.jpg;*.bmp;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the picture box
                selectedImage = Image.FromFile(ofd.FileName);
                pictureBox1.Image = selectedImage;
            }
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _); // Try to parse the input as an integer
        }

        private CancellationTokenSource searchDelay;
        private string retrievedProductName;
        private decimal retrievedSellingPrice;
        private decimal retrievedCostingPrice;
        private int retrievedQuantity;

        private async void txtproductNumber_TextChanged(object sender, EventArgs e)
        {
            CancellationTokenSource currentSearchDelay = new CancellationTokenSource();
            CancellationToken token = currentSearchDelay.Token;

            try
            {
                await Task.Delay(1000, token);
                if (!token.IsCancellationRequested)
                {
                    string enteredText = txtproductNumber.Text;

                    // Check if the entered text contains only numeric characters
                    if (!string.IsNullOrEmpty(enteredText) && IsNumeric(enteredText))
                    {
                        if (int.TryParse(enteredText, out int productNumber))
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                string selectQuery = "SELECT Product_Name, Costing_Price, Selling_Price, Quantity FROM Stocks WHERE Product_Number = @ProductNumber";
                                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                                {
                                    cmd.Parameters.AddWithValue("@ProductNumber", productNumber);

                                    SqlDataReader reader = cmd.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        string productName = reader["Product_Name"].ToString();
                                        decimal sellingPrice = Convert.ToDecimal(reader["Selling_Price"]);
                                        decimal costingPrice = Convert.ToDecimal(reader["Costing_Price"]);
                                        int quantity = Convert.ToInt32(reader["Quantity"]);

                                        retrievedProductName = productName;
                                        retrievedSellingPrice = sellingPrice;
                                        retrievedCostingPrice = costingPrice;
                                        retrievedQuantity = quantity;

                                        // Update UI with retrieved data
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            // Update UI elements here
                                            txtproductName.Text = retrievedProductName;
                                            txtSellingPrice.Text = retrievedSellingPrice.ToString();
                                            txtCostingPrice.Text = retrievedCostingPrice.ToString();
                                           
                                        });
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        txtproductNumber.Text = ""; // Clear the TextBox content
                    }
                }
            }
            catch (TaskCanceledException)
            {
                // The delay was canceled
            }
            finally
            {
                currentSearchDelay.Dispose();
            }
        }



        private void txtproductNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only numeric values and control keys (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

      

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductQuantity.Text, out int enteredQuantity))
            {
                if (enteredQuantity > retrievedQuantity)
                {
                    MessageBox.Show($"Only {retrievedQuantity} products available in stock.");
                }
                else
                {
                    txtProductQuantity.Text = enteredQuantity.ToString();
                }
            }
        }
    }
}
