using inventory_system.usercontrol;
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
    public partial class overview : Form
    {
        bool sidebarExpand;
        public overview()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            main_panel.Hide();
            userctrlLogin2.Hide();
            userctrlSignin2.Show();
            userctrlSignin2.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            main_panel.Hide();
            userctrlSignin2.Hide();
            userctrlLogin2.Show();
            userctrlLogin2.BringToFront();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
    
            main_panel.Show();
            main_panel.BringToFront();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand then minimize
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void hamburgerBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
