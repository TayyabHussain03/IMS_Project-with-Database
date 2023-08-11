using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Togglebtn_Click(object sender, EventArgs e)
        {
            usercontrolLogin1.BringToFront();
            usercontrolLogin1.Show();
            Togglebtn.BackColor = Color.FloralWhite;
            signup.BackColor = Color.White;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            userctrlSignin1.BringToFront();
            userctrlSignin1.Show();
            signup.BackColor = Color.FloralWhite;
            Togglebtn.BackColor = Color.White;
        }

        private void usercontrolLogin1_Load(object sender, EventArgs e)
        {

        }
    }
}
