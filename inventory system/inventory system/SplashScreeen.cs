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
    public partial class SplashScreeen : Form
    {
        public SplashScreeen()
        {
            InitializeComponent();
        }
        int Progress = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress = Progress + 2;
            progressBar1.Value = Progress;
            percentagelbl.Text = Progress + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void SplashScreeen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
