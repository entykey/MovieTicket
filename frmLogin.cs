namespace MovieTicket
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNetCore.Identity;
    using EFModels;
    using Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using System.Threading.Tasks;
    using AppContext = Models.AppContext;

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        #region EntityFramework entity
        CRVCinemaEntities dbContext = new CRVCinemaEntities();
        #endregion

        #region database methods
        public async Task<Users> FetchUserFromDb(string userName)
        {
            return await Task.Run(() =>
            {
                var user = dbContext.Users
                    .FirstOrDefault(c => c.UserName == userName);

                if (user != null)
                {
                    // Fetch user roles
                    var roles = dbContext.Roles
                        .Where(r => r.Users.Any(u => u.UserName == userName))
                        .Select(r => r.Name)
                        .ToList();

                    // Set user roles in AppContext
                    AppContext.Roles = roles;
                }

                return user;
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

                // Store user information in global storage
                AppContext.CurrentUser = user;
                //AppContext.CurrentUserRole = user.Role; // Assuming Role is the user's role

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

        private void btnLogin_Enter(object sender, EventArgs e)
        {
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevent the system beep sound when Enter is pressed
                e.Handled = true;

                btnLogin_Click(sender, e);
            }
        }
    }
}
