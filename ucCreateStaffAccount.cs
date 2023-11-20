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
                         select new
                         {
                             u.Id,
                             u.UserName,
                             u.Email,
                             u.DateJoined,
                             u.Discriminator
                         };

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

                    string insertUserQuery = "INSERT INTO Users (Id, UserName, NormalizedUserName, Email, PasswordHash, AccessFailedCount, Discriminator, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, SecurityStamp, LockoutEnabled, LockoutEnd, NormalizedEmail, PhoneNumber, ConcurrencyStamp, DateJoined) " +
                        "VALUES (@Id, @UserName, @NormalizedUserName, @Email, @PasswordHash, @AccessFailedCount, @Discriminator, @EmailConfirmed, @PhoneNumberConfirmed, @TwoFactorEnabled, @SecurityStamp, @LockoutEnabled, @LockoutEnd, @NormalizedEmail, @PhoneNumber, @ConcurrencyStamp, @DateJoined);";
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
                        cmd.Parameters.AddWithValue("@DateJoined", DateTime.Now);


                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã tạo tài khoản nhân viên thành công, đừng quên cấp quyền cho nhân viên!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating staff account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteUserById(string userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Globals.ConnectionString))
                {
                    connection.Open();

                    // Consider using a parameterized query to prevent SQL injection
                    string deleteUserQuery = "DELETE FROM Users WHERE Id = @UserId";

                    using (SqlCommand cmd = new SqlCommand(deleteUserQuery, connection))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tài khoản đã được xóa thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private async void btnCreateStaff_Click(object sender, EventArgs e)
        {
            await CreateStaffAccount();
        }

        private void ucCreateStaffAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedUserId = GetSelectedUserId();

            if (selectedUserId != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteUserById(selectedUserId);
                    BindDataUserToDataGv(); // Refresh DataGridView after deletion
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // helper
        private string GetSelectedUserId()
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Assuming the 'Id' column is the first column in the DataGridView
                return dgvUsers.SelectedRows[0].Cells["Id"].Value.ToString();
            }

            return null;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 13)  // ignore header row and any column
                return;

            txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();

            
            this.btnCreateStaff.Enabled = false;
            //this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnCancelSelection.Enabled = true;
        }

        private void btnCancelSelection_Click(object sender, EventArgs e)
        {
            btnCreateStaff.Enabled = true; 
            txtUserName.Text = "";
            btnDelete.Enabled = false;
        }
    }
}
