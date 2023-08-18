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
    public partial class UserControlPurchaseReturnView : UserControl
    {
        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";
        public UserControlPurchaseReturnView()
        {
            InitializeComponent();
        }

        private void UserControlPurchaseRetrunView_Load(object sender, EventArgs e)
        {
            cmbBoxReason.SelectedIndex = 0; // Select the "Please select" option by default                                          

            // Load the original DataTable and keep a reference to it

            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, S.Invoice_Number, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date" +
                   " FROM PRline_Items AS PR" +
                   " INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                   " INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    originalDataTable = new DataTable();
                    adapter.Fill(originalDataTable);
                    dataGridView1.DataSource = originalDataTable;
                }
            }

            // Attach the event handler for cmbBoxReason.SelectedIndexChanged
            cmbBoxReason.SelectedIndexChanged += cmbBoxReason_SelectedIndexChanged;

            // Load data into the DataGridView on form load
            LoadDataGridViewData();
        }

        private void cmbBoxReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Suppress the key press event
        }

        private void LoadDataGridViewData()
        {
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, S.Invoice_Number, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date" +
                " FROM PRline_Items AS PR" +
                " INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
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

        private void cmbBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected option from cmbBoxView
            string selectedOption = cmbBoxView.SelectedItem.ToString();
            string selectedReason = cmbBoxReason.SelectedItem.ToString();

            if (selectedOption == "All")
            {
                // Load all data
                LoadAllData();
            }
            else
            {
                // Load data based on the selected option and reason
                LoadData(selectedOption, selectedReason);
            }
        }

        private void LoadAllData()
        {
            // Fetch all data from the database
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, S.Invoice_Number, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date" +
                           " FROM PRline_Items AS PR" +
                           " INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                           " INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID";

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

        private void LoadData(string selectedOption, string selectedReason)
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
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, S.Invoice_Number, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date" +
                           " FROM PRline_Items AS PR" +
                           " INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                           " INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID";

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
                        string reason = row["Reason"].ToString();

                        if (salesReturnDate >= startDate && (selectedReason == "All" || reason == selectedReason))
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

        private void cmbBoxReason_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Suppress the key press event
        }

        private void cmbBoxView_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Suppress the key press event
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Load data into the DataGridView on Refresh
            LoadDataGridViewData();
            cmbBoxView.SelectedIndex = 0;
            cmbBoxReason.SelectedIndex = 0;
        }

        private DataTable originalDataTable; // Keep a reference to the original DataTable
        private void cmbBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxReason.SelectedItem != null) // Check if an item is selected
            {
                string selectedReason = cmbBoxReason.SelectedItem.ToString();

                if (cmbBoxView.SelectedItem != null) // Check if an item is selected
                {
                    string selectedOption = cmbBoxView.SelectedItem.ToString();

                    if (selectedReason == "All")
                    {
                        // Load all data
                        LoadAllData();
                    }
                    else
                    {
                        if (originalDataTable != null)
                        {
                            // Filter the rows based on the selected reason
                            DataTable filteredDataTable = originalDataTable.Clone();
                            foreach (DataRow row in originalDataTable.Rows)
                            {
                                if (row["Reason"].ToString() == selectedReason)
                                {
                                    filteredDataTable.ImportRow(row);
                                }
                            }

                            dataGridView1.DataSource = filteredDataTable;
                        }
                    }
                }
            }
        }

        private void SearchProducts(string searchText)
        {
            string query = "SELECT P.Product_Name as Name, S.Reason as Reason, S.Invoice_Number, PR.Quantity, PR.Unit_Price as Price, PR.Sub_Total as Amount, S.Purchase_Return_Date as Date" +
                           " FROM PRline_Items AS PR" +
                           " INNER JOIN Stocks AS P ON PR.Product_ID = P.Product_Number " +
                           " INNER JOIN Purchase_Return AS S ON PR.Purchase_Return_ID = S.Purchase_Return_ID" +
                           $" WHERE P.Product_Name LIKE '%{searchText}%'"; // Use LIKE to perform a partial match search

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable filteredDataTable = new DataTable();
                    da.Fill(filteredDataTable);
                    dataGridView1.DataSource = filteredDataTable;
                }
            }
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            string searchText = Convert.ToString(txtSearchProducts.Text);
            SearchProducts(searchText);
            txtSearchProducts.Text = "";
        }
    }
}
