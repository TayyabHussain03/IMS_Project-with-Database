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
    public partial class usercontrolSales : UserControl
    {
        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";
        public usercontrolSales()
        {
            InitializeComponent();

            txtQuantity.KeyPress += txtQuantity_KeyPress;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void usercontrolSales_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "Select Product_Number, Product_Name, Quantity, Costing_Price, Unit_Price, Sub_Total from tblCart";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the DataTable to your DataGridView
                dgvCartItems.DataSource = dataTable;

                // Calculate and display the total sum of Sub_Total and Costing_Price values
                CalculateAndDisplayTotal();
                CalculateAndDisplayCostingTotal();

            }

            dgvCartItems.DefaultCellStyle.Font = new Font("Arial", 7); // Adjust the font and size
            dgvCartItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Adjust the font, size, and style for column headers
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CalculateAndDisplayTotal()
        {
            decimal totalSum = 0;

            foreach (DataGridViewRow row in dgvCartItems.Rows)
            {
                decimal subTotal;
                if (decimal.TryParse(row.Cells["Sub_Total"].Value?.ToString(), out subTotal))
                {
                    totalSum += subTotal;
                }
            }

            // Update the TextBox with the calculated total sum
            txtBoxTotalPrice.Text = totalSum.ToString("0.00");
        }

        private void CalculateAndDisplayCostingTotal()
        {
            decimal totalSum = 0;

            foreach (DataGridViewRow row in dgvCartItems.Rows)
            {
                decimal costingTotal;
                if (decimal.TryParse(row.Cells["Costing_Price"].Value?.ToString(), out costingTotal))
                {
                    totalSum += costingTotal;
                }
            }

            // Update the TextBox with the calculated total sum
            txtBoxCostingPrice.Text = totalSum.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "Delete from tblCart";

                SqlCommand cmd = new SqlCommand(deleteQuery, connection);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            usercontrolSales_Load(sender, e);
            CalculateAndDisplayTotal();
            CalculateAndDisplayCostingTotal();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            usercontrolSales_Load(sender, e);
            CalculateAndDisplayTotal();

            dgvCartItems.DefaultCellStyle.Font = new Font("Arial", 7); // Adjust the font and size
            dgvCartItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Adjust the font, size, and style for column headers


        }

        private void dgvCartItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCartItems.Rows[e.RowIndex];
                string productNumber = row.Cells["Product_Number"].Value.ToString();

                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedProductNumber = Convert.ToInt32(dgvCartItems.SelectedRows[0].Cells["Product_Number"].Value);

                    // Delete the record from the database
                    SqlConnection con = new SqlConnection(connectionString);
                    string deleteQuery = "DELETE FROM tblCart WHERE Product_Number =@ProductNumber";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductNumber", selectedProductNumber);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    // Remove the selected row from the DataGridView
                    dgvCartItems.Rows.RemoveAt(dgvCartItems.SelectedRows[0].Index);

                    MessageBox.Show("Product removed successfully.");

                    CalculateAndDisplayTotal();
                    CalculateAndDisplayCostingTotal();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }

        private CancellationTokenSource searchDelay;
        private string retrievedProductName;
        private decimal retrievedSellingPrice;
        private decimal retrievedCostingPrice;
        private int retrievedQuantity;
        private decimal subTotal;

        private async void txtBoxProductNumber_TextChanged(object sender, EventArgs e)
        {
            CancellationTokenSource currentSearchDelay = new CancellationTokenSource();
            CancellationToken token = currentSearchDelay.Token;

            try
            {
                await Task.Delay(1000, token);
                if (!token.IsCancellationRequested)
                {
                    if (int.TryParse(txtBoxProductNumber.Text, out int productNumber))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string selectQuery = "SELECT Product_Name, Costing_Price, Selling_Price, Quantity FROM Products WHERE Product_Number = @ProductNumber";
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

                                    // Update retrievedQuantity here
                                    retrievedQuantity = quantity;

                                    // Calculate subtotal
                                    decimal subtotal = retrievedSellingPrice * retrievedQuantity;

                                    // Update UI with retrieved data
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        // Update UI elements here
                                        txtProductName.Text = retrievedProductName;
                                        txtSellingPrice.Text = retrievedSellingPrice.ToString();
                                        txtQuantity.Text = "";
                                        txtBoxSubtotal.Text = "0";
                                    });
                                }
                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Please enter numeric digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBoxProductNumber.Text = "";
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int enteredQuantity))
            {
                if (enteredQuantity > retrievedQuantity)
                {
                    MessageBox.Show($"Only {retrievedQuantity} products available in stock.");
                    txtBoxSubtotal.Text = "0"; // Clear sub_total if entered quantity is invalid
                }
                else
                {
                    // Calculate and update sub_total
                    subTotal = retrievedSellingPrice * enteredQuantity; // Assign the calculated subtotal here
                    txtBoxSubtotal.Text = subTotal.ToString();
                }
            }
            else
            {
                txtBoxSubtotal.Text = "0"; // Clear sub_total if entered quantity is invalid
            }
        }


        private void btnAddtoBasket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxProductNumber.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in both Product Number and Quantity fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if fields are empty
            }

            int enteredQuantity = int.Parse(txtQuantity.Text);
            if (enteredQuantity <= retrievedQuantity)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) FROM tblCart WHERE Product_Number = @ProductNumber";
                    using (SqlCommand checkCmd = new SqlCommand(selectQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductNumber", txtBoxProductNumber.Text);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            // Update the quantity and sub_total for the existing product
                            string updateQuery = "UPDATE tblCart SET Quantity = Quantity + @Quantity, Sub_Total = (Unit_Price * (Quantity + @Quantity)) WHERE Product_Number = @ProductNumber";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@Quantity", enteredQuantity);
                                updateCmd.Parameters.AddWithValue("@ProductNumber", txtBoxProductNumber.Text);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert the new product into the cart
                            string insertQuery = "INSERT INTO tblCart (Product_Number, Product_Name, Costing_Price, Quantity, Unit_Price, Sub_Total) VALUES (@ProductNumber, @ProductName, @CostingPrice, @Quantity, @UnitPrice, @SubTotal)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@ProductNumber", txtBoxProductNumber.Text);
                                insertCmd.Parameters.AddWithValue("@ProductName", retrievedProductName);
                                insertCmd.Parameters.AddWithValue("@CostingPrice", retrievedCostingPrice);
                                insertCmd.Parameters.AddWithValue("@Quantity", enteredQuantity);
                                insertCmd.Parameters.AddWithValue("@UnitPrice", retrievedSellingPrice);
                                insertCmd.Parameters.AddWithValue("@SubTotal", subTotal);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Item added to cart successfully.");
                txtBoxProductNumber.Text = "";
                txtQuantity.Text = "";
                txtProductName.Text = "";
                txtSellingPrice.Text = "";

                dgvCartItems.DefaultCellStyle.Font = new Font("Arial", 7); // Adjust the font and size
                dgvCartItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Adjust the font, size, and style for column headers
            }
            else
            {
                MessageBox.Show($"Only {retrievedQuantity} products available in stock.");
            }
        }

        //Generating Random Invoice Numbers
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int min = 10000; // Minimum 5-digit number
            int max = 999999; // Maximum 6-digit number

            Random random = new Random();
            int uniqueNumber = random.Next(min, max + 1);

            txtBoxInvoiceNum.Text = uniqueNumber.ToString();
        }

        //Add Data in relevant tables when proceeding
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxInvoiceNum.Text) && !string.IsNullOrWhiteSpace(txtBoxCustomerName.Text))
            {
                string connString = connectionString;
                string insertQuery = "INSERT INTO Customers (Customer_Name) VALUES (@CustomerName); SELECT SCOPE_IDENTITY() as Customer_ID;";
                int customerId = -1;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", txtBoxCustomerName.Text);
                        customerId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    if (customerId != -1)
                    {
                        // Check if the cart is empty
                        string selectQuery = "SELECT product_number, costing_price, unit_price, quantity, sub_total FROM tblCart";

                        using (SqlConnection connectionForSelect = new SqlConnection(connString))
                        {
                            connectionForSelect.Open();

                            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connectionForSelect))
                            {
                                using (SqlDataReader reader = selectCommand.ExecuteReader())
                                {
                                    if (reader.HasRows) // Check if there are any rows in tblCart
                                    {
                                        // Create a new SqlConnection for inserting into Sales and Sline_Items tables
                                        using (SqlConnection connectionForInsert = new SqlConnection(connectionString))
                                        {
                                            connectionForInsert.Open();

                                            string salesQuery = "INSERT INTO Sales (Sale_ID, Sale_Date, Amount, Customer_ID) VALUES (@SaleId, @SaleDate, @Amount, @CustomerId);";

                                            using (SqlCommand salesCommand = new SqlCommand(salesQuery, connectionForInsert))
                                            {
                                                string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                                                salesCommand.Parameters.AddWithValue("@SaleId", Convert.ToInt32(txtBoxInvoiceNum.Text));
                                                salesCommand.Parameters.AddWithValue("@SaleDate", formattedDate);
                                                salesCommand.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtBoxTotalPrice.Text));
                                                salesCommand.Parameters.AddWithValue("@CustomerId", customerId);
                                                salesCommand.ExecuteNonQuery();
                                            }

                                            // Insert data from Cart into Sline_Items
                                            string insertItemsQuery = "INSERT INTO Sline_Items (Sale_ID, Product_ID, Quantity, Costing_Price, Unit_Price, Sub_Total) values (@SaleId, @ProductId, @Quantity, @CostingPrice, @UnitPrice, @Subtotal);";

                                            using (SqlCommand insertItemsCommand = new SqlCommand(insertItemsQuery, connection))
                                            {
                                                while (reader.Read())
                                                {
                                                    int productNumber = Convert.ToInt32(reader["product_number"]);
                                                    decimal unitPrice = Convert.ToDecimal(reader["unit_price"]);
                                                    decimal costingPrice = Convert.ToDecimal(reader["costing_price"]);
                                                    int quantity = Convert.ToInt32(reader["quantity"]);
                                                    decimal subTotal = Convert.ToDecimal(reader["sub_total"]);

                                                    updateProductsTable(productNumber, quantity);

                                                    insertItemsCommand.Parameters.Clear(); // Clear existing parameters
                                                    insertItemsCommand.Parameters.AddWithValue("@SaleId", Convert.ToInt32(txtBoxInvoiceNum.Text));
                                                    insertItemsCommand.Parameters.AddWithValue("@ProductId", productNumber);
                                                    insertItemsCommand.Parameters.AddWithValue("@Quantity", quantity);
                                                    insertItemsCommand.Parameters.AddWithValue("@CostingPrice", costingPrice);
                                                    insertItemsCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                                    insertItemsCommand.Parameters.AddWithValue("@Subtotal", subTotal);
                                                    insertItemsCommand.ExecuteNonQuery();
                                                }
                                            }

                                            // Delete data from tblCart
                                            string deleteQuery = "DELETE FROM tblCart;";
                                            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connectionForInsert))
                                            {
                                                // Close the DataReader before executing deleteCommand
                                                reader.Close();

                                                deleteCommand.ExecuteNonQuery();
                                            }

                                            txtBoxCustomerName.Text = "";
                                            txtBoxInvoiceNum.Text = "";

                                            MessageBox.Show("Your Request has been proceed");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please add products to the cart before proceeding.");
                                        return; // Exit the method if the cart is empty
                                    }
                                }
                            }
                        }
                    }
                }

                usercontrolSales_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please Generate Invoice Number and Enter Customer Name");
            }
        }

        private void updateProductsTable(int productNumber, int purchaseQuantity)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Update Products set quantity = quantity - @purchaseQuantity where product_number = @productNumber";
            using (SqlCommand updateCommand = new SqlCommand(query, con))
            {
                con.Open();
                updateCommand.Parameters.AddWithValue("@purchaseQuantity", purchaseQuantity);
                updateCommand.Parameters.AddWithValue("@productNumber", productNumber);
                updateCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        private void txtBoxProductNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric digits and control keys (backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character input
                MessageBox.Show("Please enter numeric digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
                MessageBox.Show("Please type a numeric value.");
            }
        }
    }
}
