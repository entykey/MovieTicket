namespace MovieTicket
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNetCore.Identity;
    using EFModels;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;
    using System.Threading.Tasks;

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region EntityFramework entity
        CRVCinemaEntities dbContext = new CRVCinemaEntities();
        #endregion

        #region database methods
        public async Task<Users> FetchUserFromDb(string userName)
        {
            return await Task.Run(() =>
            {
                return dbContext.Users.FirstOrDefault(c => c.UserName == userName);
            });
        }
        #endregion

        public static string HashPasswordWithIdentityBCrypt(string password)
        {
            var hasher = new PasswordHasher<object>();
            return hasher.HashPassword(null, password);
        }

        public static bool VerifyPasswordWithIdentityBCrypt(string password, string hashedPassword)
        {
            var hasher = new PasswordHasher<object>();
            var result = hasher.VerifyHashedPassword(null, hashedPassword, password);
            bool isMatch = result == PasswordVerificationResult.Success;
            return isMatch;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // You would typically perform login logic here.

            var userName = txtUserName.Text;
            var plainPassword = txtPassword.Text;

            // Fetch the user from the database using the entered username
            var user = await FetchUserFromDb(userName);

            if (user != null && VerifyPasswordWithIdentityBCrypt(plainPassword, user.PasswordHash))
            {
                // Login successful

                // Close the login form
                this.Hide();

                // Open the dashboard form
                Home dashboardForm = new Home();
                dashboardForm.ShowDialog();

                // Close the application when the dashboard form is closed
                Application.Exit();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //// Close the login form
            //this.Hide();

            //// Close the application when the dashboard form is closed
            //Application.Exit();
        }

    }
}
