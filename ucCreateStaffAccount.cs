namespace MovieTicket
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNetCore.Identity;
    using MovieTicket.EFModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;


    public partial class ucCreateStaffAccount : UserControl
    {
        private static ucCreateStaffAccount _instance;

        public static ucCreateStaffAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCreateStaffAccount();
                return _instance;
            }
        }
        private readonly CRVCinemaEntities dbContext;
        public ucCreateStaffAccount()
        {
            InitializeComponent();
            dbContext = new CRVCinemaEntities();

            BindDataUserToDataGv();
        }

        static string HashPasswordWithIdentity(string password)
        {
            var passwordHasher = new PasswordHasher<object>();
            string hashedPassword = passwordHasher.HashPassword(null, password);
            return hashedPassword;
        }

        static bool VerifyPasswordWithIdentity(string password, string hashedPassword)
        {
            var passwordHasher = new PasswordHasher<object>();
            var result = passwordHasher.VerifyHashedPassword(null, hashedPassword, password);
            bool isMatch = result == PasswordVerificationResult.Success;

            return isMatch;
        }

        #region database method
        public void BindDataUserToDataGv()
        {
            var result = from u in dbContext.Users.ToList()
                         select u;

            dgvUsers.DataSource = result.ToList();
        }
        public async Task CreateStaffAccount()
        {

            string userName = txtUserName.Text.Trim();
            string defaultPassword = "Abc@123"; // You should handle password securely in a real application
            
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Vui lòng nhập username !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Hash the password using Bcrypt
                string hashedPassword = HashPasswordWithIdentity(defaultPassword);

                // Create user with hashed password
                using (SqlConnection connection = new SqlConnection(Globals.ConnectionString))
                {
                    connection.Open();

                    string insertUserQuery = "INSERT INTO Users (Id, UserName, NormalizedUserName, Email, PasswordHash, AccessFailedCount, Discriminator, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, SecurityStamp, LockoutEnabled, LockoutEnd, NormalizedEmail, PhoneNumber, ConcurrencyStamp) " +
                        "VALUES (@Id, @UserName, @NormalizedUserName, @Email, @PasswordHash, @AccessFailedCount, @Discriminator, @EmailConfirmed, @PhoneNumberConfirmed, @TwoFactorEnabled, @SecurityStamp, @LockoutEnabled, @LockoutEnd, @NormalizedEmail, @PhoneNumber, @ConcurrencyStamp);";
                    using (SqlCommand cmd = new SqlCommand(insertUserQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@NormalizedUserName", userName.ToUpper());
                        cmd.Parameters.AddWithValue("@Email", userName + "@example.com");
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@AccessFailedCount", 0);
                        cmd.Parameters.AddWithValue("@Discriminator", "ApplicationUser");
                        cmd.Parameters.AddWithValue("@EmailConfirmed", true);
                        cmd.Parameters.AddWithValue("@PhoneNumberConfirmed", true);
                        cmd.Parameters.AddWithValue("@TwoFactorEnabled", false);
                        cmd.Parameters.AddWithValue("@SecurityStamp", "");
                        cmd.Parameters.AddWithValue("@LockoutEnabled", false);
                        cmd.Parameters.AddWithValue("@LockoutEnd", "");
                        cmd.Parameters.AddWithValue("@NormalizedEmail", (userName + "@example.com").ToUpper());
                        cmd.Parameters.AddWithValue("@PhoneNumber", "");
                        cmd.Parameters.AddWithValue("@ConcurrencyStamp", "");
                        

                        cmd.ExecuteNonQuery();
                    }

                    // Get the newly created user's ID
                    string getUserIdQuery = "SELECT Id FROM Users WHERE UserName = @UserName;";
                    using (SqlCommand cmd = new SqlCommand(getUserIdQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);

                        string userId = cmd.ExecuteScalar()?.ToString();

                        // Add user to the Staff role
                        //if (!string.IsNullOrEmpty(userId))
                        //{
                        //    AddUserToRole(userId, "Staff");
                        //    MessageBox.Show("Staff account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error creating staff account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating staff account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddUserToRole(string userId, string roleName)
        {
            using (SqlConnection connection = new SqlConnection(Globals.ConnectionString))
            {
                connection.Open();

                string insertUserRoleQuery = "INSERT INTO UserRoles (UserId, RoleId) VALUES (@UserId, @RoleId);";
                using (SqlCommand cmd = new SqlCommand(insertUserRoleQuery, connection))
                {
                    // Retrieve RoleId by role name
                    string getRoleIdQuery = "SELECT Id FROM Roles WHERE Name = @RoleName;";
                    cmd.Parameters.AddWithValue("@RoleName", roleName);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    string roleId = cmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(roleId))
                    {
                        cmd.CommandText = insertUserRoleQuery;
                        cmd.Parameters.AddWithValue("@RoleId", roleId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        #endregion

        private async void btnCreateStaff_Click(object sender, EventArgs e)
        {
            await CreateStaffAccount();
        }
    }
}
