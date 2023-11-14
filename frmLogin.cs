namespace MovieTicket
{
    using System;
    using System.Windows.Forms;


    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // You would typically perform login logic here.
            // For this example, let's assume a successful login.

            // Close the login form
            this.Hide();

            // Open the dashboard form
            Home dashboardForm = new Home();
            dashboardForm.ShowDialog();

            // Close the application when the dashboard form is closed
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
