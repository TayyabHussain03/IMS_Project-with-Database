namespace inventory_system
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}