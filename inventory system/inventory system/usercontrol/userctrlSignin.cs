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
    public partial class userctrlSignin : UserControl
    {
        private const string connectionString = "Data Source=DESKTOP-RRIV42K\\SQLEXPRESS;Initial Catalog=dbIMS;Integrated Security=True";

        public userctrlSignin()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtemail.Text == "" || txtcontact.Text == "" || txtaddress.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Fill all the field ");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                string QRY = "Insert into Admin_user (Admin_Name, Email, Admin_Password, Contact_NO, Address_No) Values ('" + txtusername.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "')";

                SqlCommand cmd = new SqlCommand(QRY, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sign In Succesfully");
                MessageBox.Show("please Log In");

                txtusername.Text = "";
                txtemail.Text = "";
                txtpassword.Text = "";
                txtcontact.Text = "";
                txtaddress.Text = "";
            }
        }
    }
}
