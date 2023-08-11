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
            if (txtCostingPrice.Text == "" || txtproductName.Text == "" || txtproductNumber.Text == "" || txtSellingPrice.Text == "" || txtproductQuantity.Text == ""  )
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
                int quantity = Convert.ToInt32(txtproductQuantity.Text);

                if (cmbproductCategory.SelectedItem != null)
                {
                    DataRowView selectedCategory = (DataRowView)cmbproductCategory.SelectedItem;
                    int categoryId = Convert.ToInt32(selectedCategory["Product_Category_ID"]);

                    string QRY = "INSERT INTO Products (Product_Number, Product_Name, Product_Category_ID, Costing_Price, Selling_Price, Quantity, Image) VALUES (@ProductNumber, @ProductName, @CategoryId, @CostingPrice, @SellingPrice, @Quantity, @Image)";

                    using (SqlCommand cmd = new SqlCommand(QRY, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductNumber", productNumber);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        cmd.Parameters.AddWithValue("@CostingPrice", costingPrice);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

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
                        con.Close();

                        txtproductNumber.Text = "";
                        txtproductName.Text = "";
                        txtCostingPrice.Text = "";
                        txtSellingPrice.Text = "";
                        txtproductQuantity.Text = "";
                        pictureBox1.Image = Resources.no_image;

                        MessageBox.Show("Product Added Successfully");

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

        private void cmbproductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
