﻿using System.Data.SqlClient;

namespace inventory_system.usercontrol
{
    public partial class usercontrolAddCtg : UserControl
    {

        string connectionString = "Data Source=Desktop-SJVABES;Initial Catalog=dbIMS;Integrated Security=True";
        public usercontrolAddCtg()
        {
            InitializeComponent();
        }

        private void btnAddCtg_Click_1(object sender, EventArgs e)
        {
            if (txtCtgDesc.Text == "" || txtCtgName.Text == "")
            {
                MessageBox.Show("Fill all field ");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

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

        private void usercontrolAddCtg_Load(object sender, EventArgs e)
        {

        }
    }
}
