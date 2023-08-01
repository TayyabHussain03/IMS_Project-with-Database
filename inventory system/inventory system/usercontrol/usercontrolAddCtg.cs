using System.Data.SqlClient;

namespace inventory_system.usercontrol
{
    public partial class usercontrolAddCtg : UserControl
    {
        public usercontrolAddCtg()
        {
            InitializeComponent();
        }

        private void btnAddCtg_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");

            string QRY = "Insert into Products_Category (Category_Name, Description) Values ('" + txtCtgName.Text + "','" + txtCtgDesc.Text + "')";

            SqlCommand cmd = new SqlCommand(QRY, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Category Added Succesfully");

            txtCtgDesc.Text = "";
            txtCtgName.Text = "";
        }
    }
}
