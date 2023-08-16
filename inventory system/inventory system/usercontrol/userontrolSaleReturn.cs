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
    public partial class userontrolSaleReturn : UserControl
    {

        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";
        public userontrolSaleReturn()
        {
            InitializeComponent();

            cmbBoxReason.KeyPress += cmbBoxReason_KeyPress;
            cmbBoxView.KeyPress += cmbBoxView_KeyPress;


            // Attach event handlers to the relevant textboxes
            txtBoxSellingPrice.KeyPress += NumericOnly_KeyPress;
            txtBoxSellingPrice.TextChanged += NumericOnly_TextChanged;

            txtBoxProductNum.KeyPress += NumericOnly_KeyPress;
            txtBoxProductNum.TextChanged += NumericOnly_TextChanged;

            txtBoxInvNum.KeyPress += NumericOnly_KeyPress;
            txtBoxInvNum.TextChanged += NumericOnly_TextChanged;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxProductNum.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSubTotal.Text) ||
                string.IsNullOrWhiteSpace(txtBoxInvNum.Text) ||
                cmbBoxReason.SelectedItem == null)
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            if (cmbBoxReason.SelectedIndex == 0) // Index of "Please select" option
            {
                MessageBox.Show("Please select a reason.");
                return;
            }

            // Retrieve the customer ID based on the provided customer name
            int customerId = -1;
            string customerName = txtBoxCustomerName.Text.Trim();
            if (!string.IsNullOrEmpty(customerName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string customerIdQuery = "SELECT Customer_ID FROM Customers WHERE Customer_Name = @CustomerName;";
                    using (SqlCommand command = new SqlCommand(customerIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            customerId = Convert.ToInt32(result);
                        }
                    }
                }
            }

            if (customerId == -1)
            {
                // Customer does not exist, insert new customer and retrieve the generated customer ID
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertCustomerQuery = "INSERT INTO Customers (Customer_Name) VALUES (@CustomerName); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(insertCustomerQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        customerId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }

            if (customerId != -1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert data into Sales_Return table
                    string salesReturnQuery = "INSERT INTO Sales_Return (Invoice_Number, Sales_Return_Date, Reason, Sales_Return_Amount, Customer_ID) " +
                                              "VALUES (@InvoiceNumber, @ReturnDate, @Reason, @ReturnAmount, @CustomerId); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(salesReturnQuery, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceNumber", Convert.ToInt32(txtBoxInvNum.Text));
                        command.Parameters.AddWithValue("@ReturnDate", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Reason", cmbBoxReason.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@ReturnAmount", Convert.ToDecimal(txtBoxSubTotal.Text));
                        command.Parameters.AddWithValue("@CustomerId", customerId);

                        // Retrieve the generated sales_return_Id
                        int salesReturnId = Convert.ToInt32(command.ExecuteScalar());


                        // Insert data into SRline_Items table
                        string slineReturnItemsQuery = "INSERT INTO SRline_Items (Sales_Return_ID, Quantity, Unit_Price, Sub_Total, Product_Number, Invoice_Number) " +
                                                       "VALUES (@SaleReturnID, @Quantity, @UnitPrice, @Subtotal, @ProductNumber, @InvoiceNumber);";
                        using (SqlCommand insertItemsCommand = new SqlCommand(slineReturnItemsQuery, connection))
                        {
                            insertItemsCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(numericUpDown1.Value));
                            insertItemsCommand.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtBoxSellingPrice.Text));
                            insertItemsCommand.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(txtBoxSubTotal.Text));
                            insertItemsCommand.Parameters.AddWithValue("@ProductNumber", Convert.ToInt32(txtBoxProductNum.Text));
                            insertItemsCommand.Parameters.AddWithValue("@InvoiceNumber", Convert.ToInt32(txtBoxInvNum.Text));
                            insertItemsCommand.Parameters.AddWithValue("@SaleReturnID", salesReturnId);


                            // Execute the insert query
                            insertItemsCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Sales return information updated successfully.");

                        txtBoxProductNum.Clear();
                        txtBoxInvNum.Clear();
                        txtBoxSubTotal.Clear();
                        txtBoxSellingPrice.Clear();
                        numericUpDown1.Value = 0;
                        txtBoxCustomerName.Clear();

                        // Reset the ComboBox selection
                        cmbBoxReason.SelectedIndex = 0; // "Please select" option
                        cmbBoxView.SelectedIndex = 0;
                        //load datgridview
                        LoadDataGridViewData();
                    }
                }
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Calculate the subtotal based on quantity and selling price
            decimal quantity = numericUpDown1.Value;

            decimal sellingPrice;
            if (decimal.TryParse(txtBoxSellingPrice.Text, out sellingPrice))
            {
                // Calculate subtotal only if selling price is a valid decimal
                decimal subtotal = quantity * sellingPrice;
                txtBoxSubTotal.Text = subtotal.ToString() + ".00";
            }
            else
            {
                // Handle the case where selling price is not a valid decimal
                txtBoxSubTotal.Text = "0.00"; // or show an error message
            }

        }

        private void txtBoxSellingPrice_TextChanged(object sender, EventArgs e)
        {
            // Calculate the subtotal based on quantity and selling price
            decimal quantity = numericUpDown1.Value;

            decimal sellingPrice;
            if (decimal.TryParse(txtBoxSellingPrice.Text, out sellingPrice))
            {
                // Calculate and update subtotal when selling price changes
                decimal subtotal = quantity * sellingPrice;
                txtBoxSubTotal.Text = subtotal.ToString() + ".00";
            }
            else
            {
                // Handle the case where selling price is not a valid decimal
                txtBoxSubTotal.Text = "0.00"; // or show an error message
            }
        }

        private void userontrolSaleReturn_Load(object sender, EventArgs e)
        {
            cmbBoxReason.SelectedIndex = 0; // Select the "Please select" option by default

            // Load data into the DataGridView on form load
            LoadDataGridViewData();
        }

        private void LoadDataGridViewData()
        {
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, SR.Quantity, SR.Unit_Price as Price, SR.Sub_Total as Amount, S.Sales_Return_Date as Date" +
                " FROM SRline_Items AS SR" +
                " INNER JOIN Stocks AS P ON SR.Product_Number = P.Product_Number " +
                "INNER JOIN Sales_Return AS S ON SR.Sales_Return_ID = S.Sales_Return_ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Temporarily remove the event handler for cmbBoxView.SelectedIndexChanged
                    cmbBoxView.SelectedIndexChanged -= cmbBoxView_SelectedIndexChanged;

                    // Clear cmbBoxView items before adding new items
                    cmbBoxView.Items.Clear();
                    cmbBoxView.Items.AddRange(new string[] { "All", "Last 7 days", "Last 15 days", "Last 1 month", "Last 3 months", "Last 6 months", "Last 1 year", "Last 2 years", "Last 3 years", "Last 4 years" });

                    // Reattach the event handler for cmbBoxView.SelectedIndexChanged
                    cmbBoxView.SelectedIndexChanged += cmbBoxView_SelectedIndexChanged;

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            cmbBoxView.SelectedIndex = 0;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 7); // Adjust the font and size
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Adjust the font, size, and style for column headers
        }


        private void cmbBoxReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Suppress the key press event
        }

        private void cmbBoxView_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Suppress the key press event
        }

        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace, Delete)
            if (!char.IsControl(e.KeyChar))
            {
                // Allow numeric characters only
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Suppress the key press
                }
            }
        }

        private void NumericOnly_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (!string.IsNullOrEmpty(textBox.Text) && !int.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Please provide a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = string.Empty; // Clear the textbox
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Load data into the DataGridView on Refresh
            LoadDataGridViewData();
            cmbBoxView.SelectedIndex = 0;
        }

        private void cmbBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected option from cmbBoxView
            string selectedOption = cmbBoxView.SelectedItem.ToString();

            if (selectedOption == "All")
            {
                // Load all data
                LoadAllData();
            }
            else
            {
                // Load data based on the selected option
                LoadData(selectedOption);
            }
        }

        private void LoadAllData()
        {
            // Fetch all data from the database
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, SR.Quantity, SR.Unit_Price as Price, SR.Sub_Total as Amount, S.Sales_Return_Date as Date" +
                           " FROM SRline_Items AS SR" +
                           " INNER JOIN Stocks AS P ON SR.Product_Number = P.Product_Number " +
                           " INNER JOIN Sales_Return AS S ON SR.Sales_Return_ID = S.Sales_Return_ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void LoadData(string selectedOption)
        {
            DateTime currentDate = DateTime.Now;
            DateTime startDate = currentDate;

            switch (selectedOption)
            {
                case "Last 7 days":
                    startDate = currentDate.AddDays(-7);
                    break;
                case "Last 15 days":
                    startDate = currentDate.AddDays(-15);
                    break;
                case "Last 1 month":
                    startDate = currentDate.AddMonths(-1);
                    break;
                case "Last 3 months":
                    startDate = currentDate.AddMonths(-3);
                    break;
                case "Last 6 months":
                    startDate = currentDate.AddMonths(-6);
                    break;
                case "Last 1 year":
                    startDate = currentDate.AddYears(-1);
                    break;
                case "Last 2 years":
                    startDate = currentDate.AddYears(-2);
                    break;
                case "Last 3 years":
                    startDate = currentDate.AddYears(-3);
                    break;
                case "Last 4 years":
                    startDate = currentDate.AddYears(-4);
                    break;
            }

            // Fetch data from the database using the start date
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, SR.Quantity, SR.Unit_Price as Price, SR.Sub_Total as Amount, S.Sales_Return_Date as Date" +
                           " FROM SRline_Items AS SR" +
                           " INNER JOIN Stocks AS P ON SR.Product_Number = P.Product_Number " +
                           " INNER JOIN Sales_Return AS S ON SR.Sales_Return_ID = S.Sales_Return_ID";

            List<DataRow> filteredRows = new List<DataRow>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime salesReturnDate = Convert.ToDateTime(row["Date"]);
                        if (salesReturnDate >= startDate)
                        {
                            filteredRows.Add(row);
                        }
                    }
                }
            }

            DataTable filteredDataTable = new DataTable();
            if (filteredRows.Count > 0)
            {
                filteredDataTable = filteredRows.CopyToDataTable();
            }

            DataView dv = new DataView(filteredDataTable); // Create a DataView from the filtered DataTable
            dataGridView1.DataSource = dv; // Set the DataView as the DataSource


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxProductNum.Clear();
            txtBoxInvNum.Clear();
            txtBoxSubTotal.Clear();
            txtBoxSellingPrice.Clear();
            numericUpDown1.Value = 0;
            txtBoxCustomerName.Clear();

            // Reset the ComboBox selection
            cmbBoxReason.SelectedIndex = 0; // "Please select" option
            cmbBoxView.SelectedIndex = 0;
            //load datgridview
            LoadDataGridViewData();
        }
    }
}
