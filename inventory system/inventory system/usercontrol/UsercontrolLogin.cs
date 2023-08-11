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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventory_system.usercontrol
{
    public partial class UsercontrolLogin : UserControl
    {
        private SqlConnection connection = new SqlConnection("Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True");
        public UsercontrolLogin()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Fill All Field");
            }
            else
            {
                string email = txtemail.Text;
                string password = txtpassword.Text;

                string query = "SELECT COUNT(*) FROM Admin_user WHERE Email = @email AND Admin_Password = @Password";
               
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();


                    if (count > 0)
                    {
                        //string name = "SELECT Admin_Name FROM Admin_user WHERE Email = '" + txtemail + "'";
                        //using (SqlCommand username = new SqlCommand(name, connection))
                        //{
                        //    using (SqlDataReader Reader = username.ExecuteReader())
                        //    {

                        //        if (Reader.Read())
                        //        {
                        //            // Set parameters if needed

                        //            string result = Reader["Admin_Name"].ToString();

                        //            MessageBox.Show(result + "jj");

                        string result = "Hurairah";
                        string loggedInUsername = result;
                        dashboard dashboard = new dashboard(loggedInUsername);
                        dashboard.Show();
                        this.Hide();
                        userctrlSignin signin = new userctrlSignin();
                        signin.Show();
                        signin.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");
                        txtemail.Focus();
                        txtpassword.Focus();
                    }
                }
            }
        }
    }
}
