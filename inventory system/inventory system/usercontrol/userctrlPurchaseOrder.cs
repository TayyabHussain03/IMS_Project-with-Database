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
    public partial class userctrlPurchaseOrder : UserControl
    {
        string connectionString = "Data Source=DESKTOP-RRIV42K\\SQLEXPRESS;Initial Catalog=dbIMS;Integrated Security=True";

        public userctrlPurchaseOrder()
        {
            InitializeComponent();

            // Set default values and restrict quantity to minimum 1
            numericUpDown1.Value = 1;
            numericUpDown1.Minimum = 0;

            // Set default values for costing price and selling price
            txtBoxCostingPrice.Text = "0.00";
            txtBoxSellingPrice.Text = "0.00";

            // Wire up the ValueChanged event handler for numericUpDown1 (Quantity)
            numericUpDown1.ValueChanged += UpdateSubTotal;

            // Wire up the TextChanged event handler for txtBoxCostingPrice
            txtBoxCostingPrice.TextChanged += UpdateSubTotal;

            txtBoxSellingPrice.TextChanged += UpdateSubTotal;
            numericUpDown1.ValueChanged += UpdateSubTotal;

            // Attach event handlers to the relevant textboxes
            txtBoxPONum.KeyPress += NumericOnly_KeyPress;
            txtBoxPONum.TextChanged += NumericOnly_TextChanged;

            txtBoxProductNum.KeyPress += NumericOnly_KeyPress;
            txtBoxProductNum.TextChanged += NumericOnly_TextChanged;
        }

        private void PopulateDataGridView(string queryPurchase)
        {
            // Assuming you have a connection to the database named 'connection'
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve data from the tblPurchase cart
                string query = queryPurchase;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            CalculateAndDisplayTotal();
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 7); // Adjust the font and size
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold); // Adjust the font, size, and style for column headers
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSubTotal_TextChanged(object sender, EventArgs e)
        {

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

        // Event handler for validating pasted text
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

        // Event handler to update the subtotal
        private void UpdateSubTotal(object sender, EventArgs e)
        {
            decimal costingPrice;
            int quantity;

            if (decimal.TryParse(txtBoxCostingPrice.Text, out costingPrice) && int.TryParse(numericUpDown1.Value.ToString(), out quantity))
            {
                decimal subtotal = costingPrice * quantity;
                txtBoxSubTotal.Text = subtotal.ToString();
            }
            else
            {
                txtBoxSubTotal.Clear();
            }
        }

        private void CalculateAndDisplayTotal()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Sub_Total"].Value != null && decimal.TryParse(row.Cells["Sub_Total"].Value.ToString(), out decimal subTotal))
                {
                    totalAmount += subTotal;
                }
            }

            txtBoxTotalAmount.Text = totalAmount.ToString("0.00");
        }


        private void btnAddinPurchase_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txtBoxSupplierName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPONum.Text) ||
                string.IsNullOrWhiteSpace(txtBoxProductNum.Text) ||
                string.IsNullOrWhiteSpace(txtBoxProductName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCostingPrice.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSellingPrice.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSubTotal.Text) ||
                cmbBoxPayment.SelectedItem == null ||
                numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please provide all details.");
                return;
            }

            if (dateTimePicker2.Value.Date == dateTimePicker3.Value.Date)
            {
                MessageBox.Show("Expiry date and manufacturing date cannot be the same.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }

            if (cmbBoxPayment.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a payment type.", "Payment Type Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without adding to the cart
            }

            // Show the message box and check the result
            var result = MessageBox.Show("Do you want to add the data to the purchase cart?", "Confirmation", MessageBoxButtons.OKCancel);

            // Check if the result is not OK (user clicked Cancel)
            if (result != DialogResult.OK)
            {
                return;
            }

            // Parse numeric values
            decimal costingPrice;
            decimal sellingPrice;
            int quantity;

            if (!decimal.TryParse(txtBoxCostingPrice.Text, out costingPrice) ||
                !decimal.TryParse(txtBoxSellingPrice.Text, out sellingPrice) ||
                !int.TryParse(numericUpDown1.Value.ToString(), out quantity))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            // Calculate subtotal
            decimal subtotal = costingPrice * quantity;
            txtBoxSubTotal.Text = subtotal.ToString();

            // Insert data into the database
            string query = "INSERT INTO tblPurchaseCart (PO_number, Product_Number, Product_Name, Costing_Price, Selling_Price, Quantity, Sub_Total, MFG_Date, Expiry_Date, Purchasing_Date, Supplier_Name, Payment_Type) " +
                           "VALUES (@PONumber, @ProductNumber, @ProductName, @CostingPrice, @SellingPrice, @Quantity, @SubTotal, @MFGDate, @ExpiryDate, @PurchasingDate, @SupplierName, @PaymentType)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PONumber", txtBoxPONum.Text);
                    command.Parameters.AddWithValue("@ProductNumber", txtBoxProductNum.Text);
                    command.Parameters.AddWithValue("@ProductName", txtBoxProductName.Text);
                    command.Parameters.AddWithValue("@CostingPrice", costingPrice);
                    command.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@SubTotal", subtotal);
                    command.Parameters.AddWithValue("@MFGDate", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@ExpiryDate", dateTimePicker3.Value);
                    command.Parameters.AddWithValue("@PurchasingDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@SupplierName", txtBoxSupplierName.Text);
                    command.Parameters.AddWithValue("@PaymentType", cmbBoxPayment.SelectedItem.ToString());

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data added to purchase cart.");

            // Clear fields
            txtBoxProductNum.Clear();
            txtBoxProductName.Clear();
            txtBoxCostingPrice.Clear();
            txtBoxSellingPrice.Clear();
            txtBoxSubTotal.Clear();
            numericUpDown1.Value = 0;
            cmbBoxPayment.SelectedIndex = -1;
            PopulateDataGridView("Select * from tblPurchaseCart");
        }

        private void userctrlPurchaseOrder_Load(object sender, EventArgs e)
        {
            PopulateDataGridView("Select * from tblPurchaseCart");
            cmbBoxPayment.Items.Insert(0, "Please Select");
            cmbBoxPayment.SelectedIndex = 0; // Set the selected index to "Please Select"
        }

        private void cmbBoxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Suppress the key press event
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateDataGridView("Select * from tblPurchaseCart");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear your cart?", "Confirm Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User confirmed, clear the cart
                ClearCart();
            }
        }
        private void ClearCart()
        {
            // Repopulate the DataGridView or clear it, depending on your needs
            PopulateDataGridView("delete from tblPurchaseCart");

            // Rest of your code for adjusting fonts
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 7);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void DeleteEntryByPONumber(string productNumber)
        {
            PopulateDataGridView("Delete from tblPurchaseCart where Product_Number = '" + productNumber + "'");
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int rowIndex = selectedCell.RowIndex;

                if (dataGridView1.Rows[rowIndex].Cells["PO_Number"].Value != null)
                {
                    string productNumber = dataGridView1.Rows[rowIndex].Cells["Product_Number"].Value.ToString();

                    // Display a confirmation dialog before deleting the entry
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the entry with PO Number: {productNumber}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Delete the entry from the database using the PO_Number
                        DeleteEntryByPONumber(productNumber);

                        // Refresh the DataGridView
                        PopulateDataGridView("SELECT * FROM tblPurchaseCart");

                        MessageBox.Show($"Entry with PO Number: {productNumber} has been deleted.", "Entry Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            CalculateAndDisplayTotal();
        }
    }
}




