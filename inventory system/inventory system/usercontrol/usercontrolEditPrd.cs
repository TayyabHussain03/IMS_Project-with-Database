﻿using inventory_system.Properties;
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
    public partial class usercontrolEditPrd : UserControl
    {
        private Image selectedImage = null;
        // Public properties to store the data
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal CostingPrice { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public Image ProductImage { get; set; }

        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";

        public usercontrolEditPrd()
        {
            InitializeComponent();
        }

        private int retrievedQuantity;
        private void usercontrolEditPrd_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products_Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbproductCategory.DataSource = dt;
            cmbproductCategory.DisplayMember = "Category_Name";
            cmbproductCategory.ValueMember = "Product_Category_ID";

            txtproductNumber.Text = Convert.ToString(ProductNumber);
            txtproductName.Text = ProductName;
            txtCostingPrice.Text = Convert.ToString(CostingPrice);
            txtSellingPrice.Text = Convert.ToString(SellingPrice);
            pictureBox1.Image = ProductImage;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Quantity from Stocks where Product_Number = @ProductNumber";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductNumber", ProductNumber);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        retrievedQuantity = quantity;
                        txtproductQuantity.Text = retrievedQuantity.ToString();
                    }
                }
            }

        }

        private byte[] SavePhoto(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Return null to indicate a failure to save the image.
            }
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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string productNumber = txtproductNumber.Text;
            string productName = txtproductName.Text;
            decimal costingPrice = Convert.ToDecimal(txtCostingPrice.Text);
            decimal sellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
            int quantity = Convert.ToInt32(txtproductQuantity.Text);
            string category = cmbproductCategory.Text.ToString();

            if (cmbproductCategory.SelectedItem != null)
            {
                DataRowView selectedCategory = (DataRowView)cmbproductCategory.SelectedItem;
                int categoryId = Convert.ToInt32(selectedCategory["Product_Category_ID"]);

                if (Convert.ToInt32(txtproductQuantity.Text) > retrievedQuantity)
                {
                    MessageBox.Show($"Only {retrievedQuantity} products available in stock.");
                }
                else
                {
                    string QRY = "UPDATE Products SET Product_Number = @ProductNumber, Product_Name = @ProductName, Product_Category_ID = @CategoryId, Costing_Price = @CostingPrice, Selling_Price = @SellingPrice, Quantity = Quantity + @NewQuantity, Image = @Image WHERE Product_ID = @ProductId";

                    using (SqlCommand cmd = new SqlCommand(QRY, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", ProductID);
                        cmd.Parameters.AddWithValue("@ProductNumber", productNumber);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        cmd.Parameters.AddWithValue("@CostingPrice", costingPrice);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                        cmd.Parameters.AddWithValue("@NewQuantity", quantity);

                        // Use the selected image if available, otherwise save the current image
                        if (selectedImage != null)
                        {
                            cmd.Parameters.AddWithValue("@Image", SavePhoto(selectedImage));

                        }
                        else
                        {
                            // Use the existing ProductImage value instead of saving a new image.
                            cmd.Parameters.AddWithValue("@Image", SavePhoto(ProductImage));
                            cmd.Parameters["@Image"].IsNullable = true;

                        }
                        con.Open();
                        cmd.ExecuteNonQuery();

                        // Subtract the entered quantity from the stock quantity in the Stocks table
                        string updateStockQuery = "UPDATE Stocks SET Quantity = Quantity - @Quantity WHERE Product_Number = @ProductNumber AND Quantity >= @Quantity"; // Add condition to check available quantity
                        using (SqlCommand updateCmd = new SqlCommand(updateStockQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@ProductNumber", productNumber);
                            updateCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtproductQuantity.Text)); // Use entered quantity
                            updateCmd.ExecuteNonQuery();
                        }

                        con.Close();

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        txtproductNumber.Text = "";
                        txtproductName.Text = "";
                        txtCostingPrice.Text = "";
                        txtSellingPrice.Text = "";
                        txtproductQuantity.Text = "";
                        pictureBox1.Image = Resources.no_image;

                        MessageBox.Show("Product Updated Successfully");

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }

        }

        private void txtproductQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtproductQuantity.Text, out int enteredQuantity))
            {
                if (enteredQuantity > retrievedQuantity)
                {
                    MessageBox.Show($"Only {retrievedQuantity} products available in stock.");
                }
                else
                {
                    txtproductQuantity.Text = enteredQuantity.ToString();
                }
            }
        }
    }
}
