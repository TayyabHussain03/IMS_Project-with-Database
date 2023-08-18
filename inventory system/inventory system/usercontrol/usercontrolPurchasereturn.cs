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
    public partial class usercontrolPurchasereturn : UserControl
    {
        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";
        public usercontrolPurchasereturn()
        {
            InitializeComponent();
            cmbBoxReason.KeyPress += cmbBoxReason_KeyPress;
            cmbBoxView.KeyPress += cmbBoxView_KeyPress;

            // Attach event handlers to the relevant textboxes
            txtBoxPurchasingPrice.KeyPress += NumericOnly_KeyPress;
            txtBoxPurchasingPrice.TextChanged += NumericOnly_TextChanged;

            txtBoxProductNum.KeyPress += NumericOnly_KeyPress;
            txtBoxProductNum.TextChanged += NumericOnly_TextChanged;

            txtBoxInvNum.KeyPress += NumericOnly_KeyPress;
            txtBoxInvNum.TextChanged += NumericOnly_TextChanged;
        }

        private void usercontrolPurchasereturn_Load(object sender, EventArgs e)
        {
            cmbBoxReason.SelectedIndex = 0; // Select the "Please select" option by default

            // Load data into the DataGridView on form load
            LoadDataGridViewData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSupplierName.Text) ||
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

            // Retrieve the supplier ID based on the provided supplier name
            int supplierId = -1;
            string supplierName = txtBoxSupplierName.Text.Trim();
            if (!string.IsNullOrEmpty(supplierName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string customerIdQuery = "SELECT Supplier_ID FROM Supplier WHERE Supplier_Name = @SupplierName;";
                    using (SqlCommand command = new SqlCommand(customerIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            supplierId = Convert.ToInt32(result);
                        }
                    }
                }
            }

            if (supplierId != -1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert data into Purchase_Return table
                    string PurchaseReturnQuery = "INSERT INTO Purchase_Return (Invoice_Number, Purchase_Return_Date, Reason, Amount, Supplier_ID) " +
                                              "VALUES (@InvoiceNumber, @ReturnDate, @Reason, @ReturnAmount, @SupplierId); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(PurchaseReturnQuery, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceNumber", Convert.ToInt32(txtBoxInvNum.Text));
                        command.Parameters.AddWithValue("@ReturnDate", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Reason", cmbBoxReason.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@ReturnAmount", Convert.ToDecimal(txtBoxSubTotal.Text));
                        command.Parameters.AddWithValue("@SupplierId", supplierId);

                        // Retrieve the generated purchase_return_Id
                        int purchaseReturnId = Convert.ToInt32(command.ExecuteScalar());


                        // Insert data into SRline_Items table
                        string plineReturnItemsQuery = "INSERT INTO PRline_Items (Purchase_Return_ID, Quantity, Unit_Price, Sub_Total, Product_ID, Invoice_Number) " +
                                                       "VALUES (@PurchaseReturnID, @Quantity, @UnitPrice, @Subtotal, @ProductNumber, @InvoiceNumber);";
                        using (SqlCommand insertItemsCommand = new SqlCommand(plineReturnItemsQuery, connection))
                        {
                            insertItemsCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(numericUpDown1.Value));
                            insertItemsCommand.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtBoxPurchasingPrice.Text));
                            insertItemsCommand.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(txtBoxSubTotal.Text));
                            insertItemsCommand.Parameters.AddWithValue("@ProductNumber", Convert.ToInt32(txtBoxProductNum.Text));
                            insertItemsCommand.Parameters.AddWithValue("@InvoiceNumber", Convert.ToInt32(txtBoxInvNum.Text));
                            insertItemsCommand.Parameters.AddWithValue("@PurchaseReturnID", purchaseReturnId);


                            // Execute the insert query
                            insertItemsCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("purchase return information updated successfully.");

                        txtBoxProductNum.Clear();
                        txtBoxInvNum.Clear();
                        txtBoxSubTotal.Text = "0.00";
                        txtBoxPurchasingPrice.Text = "0.00";
                        numericUpDown1.Value = 0;
                        txtBoxSupplierName.Clear();

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
            // Calculate the subtotal based on quantity and purchasing price
            decimal quantity = numericUpDown1.Value;

            decimal purchaingPrice;
            if (decimal.TryParse(txtBoxPurchasingPrice.Text, out purchaingPrice))
            {
                // Calculate subtotal only if purchasing price is a valid decimal
                decimal subtotal = quantity * purchaingPrice;
                txtBoxSubTotal.Text = subtotal.ToString() + ".00";
            }
            else
            {
                // Handle the case where purchasing price is not a valid decimal
                txtBoxSubTotal.Text = "0.00"; // or show an error message
            }

        }

        private void txtBoxPurchasingPrice_TextChanged(object sender, EventArgs e)
        {
            // Calculate the subtotal based on quantity and selling price
            decimal quantity = numericUpDown1.Value;

            decimal purchasingPrice;
            if (decimal.TryParse(txtBoxPurchasingPrice.Text, out purchasingPrice))
            {
                // Calculate and update subtotal when purchasing price changes
                decimal subtotal = quantity * purchasingPrice;
                txtBoxSubTotal.Text = subtotal.ToString() + ".00";
            }
            else
            {
                // Handle the case where purchasing price is not a valid decimal
                txtBoxSubTotal.Text = "0.00"; // or show an error message
            }
        }

        private void LoadDataGridViewData()
        {
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date " +
                "FROM PRline_Items AS PR " +
                "INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                "INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID";

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
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date " +
                "FROM PRline_Items AS PR " +
                "INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                "INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID";

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
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date " +
                    "FROM PRline_Items AS PR " +
                    "INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                    "INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID";

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
                        DateTime purchaseReturnDate = Convert.ToDateTime(row["Date"]);
                        if (purchaseReturnDate >= startDate)
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
            txtBoxSubTotal.Text = "0.00";
            txtBoxPurchasingPrice.Text = "0.00";
            numericUpDown1.Value = 0;
            txtBoxSupplierName.Clear();

            // Reset the ComboBox selection
            cmbBoxReason.SelectedIndex = 0; // "Please select" option
            cmbBoxView.SelectedIndex = 0;
            //load datgridview
            LoadDataGridViewData();
        }

        private void btnPurchaseReturnView_Click(object sender, EventArgs e)
        {
            Form purchaseReturnView = new Form();
            UserControlPurchaseReturnView usPurchaseReturnView = new UserControlPurchaseReturnView();
            usPurchaseReturnView.Dock = DockStyle.Fill;
            purchaseReturnView.Controls.Add(usPurchaseReturnView);
            purchaseReturnView.Size = new Size(780, 589);
            purchaseReturnView.StartPosition = FormStartPosition.CenterScreen;
            purchaseReturnView.ShowDialog();
        }
    }
}
