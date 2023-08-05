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
        private const string connString = "Data Source=DESKTOP-RRIV42K\\SQLEXPRESS;Initial Catalog=dbIMS-1;Integrated Security=True";

        public usercontrolSales()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void usercontrolSales_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string selectQuery = "Select Product_Number, Product_Name, Quantity, Unit_Price, Sub_Total from tblCart";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the DataTable to your DataGridView
                dgvCartItems.DataSource = dataTable;

                // Calculate and display the total sum of Sub_Total values
                CalculateAndDisplayTotal();
            }


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string deleteQuery = "Delete from tblCart";

                SqlCommand cmd = new SqlCommand(deleteQuery, connection);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            usercontrolSales_Load(sender, e);
            CalculateAndDisplayTotal();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            usercontrolSales_Load(sender, e);
            CalculateAndDisplayTotal();
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
                    SqlConnection con = new SqlConnection(connString);
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
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            connection.Open();

                            string selectQuery = "SELECT Product_Name, Selling_Price, Quantity FROM Products WHERE Product_Number = @ProductNumber";
                            using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@ProductNumber", productNumber);

                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    string productName = reader["Product_Name"].ToString();
                                    decimal sellingPrice = Convert.ToDecimal(reader["Selling_Price"]);
                                    int quantity = Convert.ToInt32(reader["Quantity"]);

                                    retrievedProductName = productName;
                                    retrievedSellingPrice = sellingPrice;

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
                        MessageBox.Show("Please enter numeric digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                using (SqlConnection connection = new SqlConnection(connString))
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
                            string insertQuery = "INSERT INTO tblCart (Product_Number, Product_Name, Quantity, Unit_Price, Sub_Total) VALUES (@ProductNumber, @ProductName, @Quantity, @UnitPrice, @SubTotal)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@ProductNumber", txtBoxProductNumber.Text);
                                insertCmd.Parameters.AddWithValue("@ProductName", retrievedProductName);
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
            int max = 99999; // Maximum 5-digit number

            Random random = new Random();
            int uniqueNumber = random.Next(min, max + 1);

            txtBoxInvoiceNum.Text = uniqueNumber.ToString();
        }

        //Add Data in relevant tables when proceeding
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtBoxCustomerName.Text == "" || txtBoxInvoiceNum.Text == "")
            {
                MessageBox.Show("Enter Customer name and invoice");
            }
            else
            {
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
                        string salesQuery = "INSERT INTO Sales (Sale_ID, Sale_Date, Amount, Customer_ID) VALUES (@SaleId, @SaleDate, @Amount, @CustomerId);";

                        string selectQuery = "SELECT product_number, unit_price, quantity, sub_total FROM tblCart";

                        using (SqlCommand salesCommand = new SqlCommand(salesQuery, connection))
                        {
                            string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            salesCommand.Parameters.AddWithValue("@SaleId", Convert.ToInt32(txtBoxInvoiceNum.Text));
                            salesCommand.Parameters.AddWithValue("@SaleDate", formattedDate);
                            salesCommand.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtBoxTotalPrice.Text));
                            salesCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            salesCommand.ExecuteNonQuery();
                        }

                        using (SqlConnection connectionForInsert = new SqlConnection(connString))
                        {
                            connectionForInsert.Open();

                            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                            {
                                using (SqlDataReader reader = selectCommand.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        int productNumber = Convert.ToInt32(reader["product_number"]);
                                        decimal unitPrice = Convert.ToDecimal(reader["unit_price"]);
                                        int quantity = Convert.ToInt32(reader["quantity"]);
                                        decimal subTotal = Convert.ToDecimal(reader["sub_total"]);

                                        string insertItemsQuery = "INSERT INTO Sline_Items (Sale_ID, Product_ID, Quantity, Unit_Price, Sub_Total) values (@SaleId, @ProductId, @Quantity, @UnitPrice, @Subtotal);";

                                        using (SqlCommand insertItemsCommand = new SqlCommand(insertItemsQuery, connectionForInsert))
                                        {
                                            insertItemsCommand.Parameters.AddWithValue("@SaleId", Convert.ToInt32(txtBoxInvoiceNum.Text));
                                            insertItemsCommand.Parameters.AddWithValue("@ProductId", productNumber);
                                            insertItemsCommand.Parameters.AddWithValue("@Quantity", quantity);
                                            insertItemsCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                            insertItemsCommand.Parameters.AddWithValue("@Subtotal", subTotal);
                                            insertItemsCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }

                        // Delete data from tblCart
                        string deleteQuery = "DELETE FROM tblCart;";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.ExecuteNonQuery();
                        }
                    }
                }
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
    }
}
