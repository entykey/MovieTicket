namespace MovieTicket
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.Data.SqlClient;
    using MovieTicket.EFModels;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;



    public partial class ucAssignRole : UserControl
    {
        private static ucAssignRole _instance;

        public static ucAssignRole Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAssignRole();
                return _instance;
            }
        }

        public class UserRoleInfo
        {
            public string RoleId { get; set; }
            public string RoleName { get; set; }
            public bool IsInRole { get; set; }
        }

        #region EntityFramework entity
        public readonly CRVCinemaEntities dbContext;
        #endregion

        private List<Roles> allRoles;

        #region form events
        public ucAssignRole()
        {
            InitializeComponent();
            dbContext =  new CRVCinemaEntities();

            //LoadUserNames();
            //LoadAllRoles();

        }

        private void ucAssignRole_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region database operations
        private async Task LoadUserNames()
        {
            var userNames = await dbContext.Users
                .Select(u => u.UserName)
                .ToListAsync();

            cboUserNames.DataSource = userNames;
        }

        #endregion

        private async void cboUserNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedUserName = cboUserNames.SelectedItem?.ToString();

            // EF approach
            //if (!string.IsNullOrEmpty(selectedUserName))
            //{
            //    var selectedUser = await dbContext.Users
            //        .FirstOrDefaultAsync(u => u.UserName == selectedUserName);

            //    // doesn't help a shit !
            //    //await Task.Delay(1000);

            //    if (selectedUser != null)
            //    {
            //        // Load roles for the selected user
            //        var userRoles = await dbContext.Roles
            //            .Where(r => selectedUser.Roles.Any(ur => ur.Id == r.Id))
            //            .ToListAsync();

            //        // Update the DataGridView to mark roles that the user is in
            //        foreach (DataGridViewRow row in dgvRoles.Rows)
            //        {
            //            var role = (IdentityRole)row.DataBoundItem;
            //            row.Cells["IsInRole"].Value = userRoles.Any(ur => ur.Id == role.Id);
            //        }
            //    }
            //}


            string selectedUserName = cboUserNames.SelectedItem?.ToString();

            // approach 2 (no more errors, but only show roles of a user)
            //// Fetch user roles
            //allRoles = await dbContext.Roles
            //    .Where(r => r.Users.Any(u => u.UserName == selectedUserName))
            //    .ToListAsync();
            //// bind data to dgv
            //dgvRoles.DataSource = allRoles.Select(r => new { r.Id, r.Name }).ToList();

            // ADO.NET approach
            List<UserRoleInfo> userRolesInfo = new List<UserRoleInfo>();

            using (var connection = new SqlConnection(Globals.ConnectionString))
            {
                connection.Open();

                // Fetch user ID based on the username
                var userIdQuery = "SELECT Id FROM Users WHERE UserName = @UserName";
                using (var getUserIdCommand = new SqlCommand(userIdQuery, connection))
                {
                    getUserIdCommand.Parameters.AddWithValue("@UserName", selectedUserName);

                    var userId = getUserIdCommand.ExecuteScalar() as string;

                    if (userId != null)
                    {
                        // Fetch user roles
                        var userRolesQuery = "SELECT r.Id, r.Name FROM Roles r " +
                                             "JOIN UserRoles ur ON r.Id = ur.RoleId " +
                                             "WHERE ur.UserId = @UserId";

                        using (var getUserRolesCommand = new SqlCommand(userRolesQuery, connection))
                        {
                            getUserRolesCommand.Parameters.AddWithValue("@UserId", userId);

                            using (var reader = getUserRolesCommand.ExecuteReader())
                            {
                                var allRoles = new List<string>();

                                while (reader.Read())
                                {
                                    allRoles.Add(reader["Name"].ToString());
                                }

                                // Fetch all roles
                                var allRolesQuery = "SELECT r.Id, r.Name FROM Roles r";

                                using (var getAllRolesCommand = new SqlCommand(allRolesQuery, connection))
                                using (var allRolesReader = getAllRolesCommand.ExecuteReader())
                                {
                                    while (allRolesReader.Read())
                                    {
                                        var roleId = allRolesReader["Id"].ToString();
                                        var roleName = allRolesReader["Name"].ToString();
                                        
                                        userRolesInfo.Add(new UserRoleInfo
                                        {
                                            RoleId = roleId,
                                            RoleName = roleName,
                                            IsInRole = allRoles.Contains(roleName)
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }

            dgvRoles.DataSource = userRolesInfo;
        }

        //private async void btnUpdateRole_Click(object sender, EventArgs e)
        //{
        //    string selectedUserName = cboUserNames.SelectedItem.ToString();
        //    var selectedUser = await dbContext.Users
        //        .FirstOrDefaultAsync(u => u.UserName == selectedUserName);

        //    if (selectedUser != null)
        //    {
        //        // Update user roles based on DataGridView
        //        foreach (DataGridViewRow row in dgvRoles.Rows)
        //        {
        //            var role = (Roles)row.DataBoundItem;
        //            bool isInRole = Convert.ToBoolean(row.Cells["colIsInRole"].Value);

        //            if (isInRole)
        //            {
        //                dbContext.UserRoles.Add(new IdentityUserRole
        //                {
        //                    UserId = selectedUser.Id,
        //                    RoleId = role.Id
        //                });
        //            }
        //            else
        //            {
        //                var userRole = await dbContext.UserRoles
        //                    .FirstOrDefaultAsync(ur => ur.UserId == selectedUser.Id && ur.RoleId == role.Id);

        //                if (userRole != null)
        //                {
        //                    dbContext.UserRoles.Remove(userRole);
        //                }
        //            }
        //        }

        //        await dbContext.SaveChangesAsync();
        //        MessageBox.Show("Roles updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        private async void btnUpdateRole_Click(object sender, EventArgs e)
        {

            string selectedUserName = cboUserNames.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedUserName))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(Globals.ConnectionString))
                    {
                        await connection.OpenAsync();

                        // Clear existing roles for the user
                        string clearRolesQuery = "DELETE FROM UserRoles WHERE UserId = (SELECT Id FROM Users WHERE UserName = @UserName)";
                        using (SqlCommand clearRolesCommand = new SqlCommand(clearRolesQuery, connection))
                        {
                            clearRolesCommand.Parameters.AddWithValue("@UserName", selectedUserName);
                            await clearRolesCommand.ExecuteNonQueryAsync();
                        }

                        // Add selected roles for the user
                        string addRolesQuery = "INSERT INTO UserRoles (UserId, RoleId) VALUES ((SELECT Id FROM Users WHERE UserName = @UserName), @RoleId)";
                        using (SqlCommand addRolesCommand = new SqlCommand(addRolesQuery, connection))
                        {
                            foreach (DataGridViewRow row in dgvRoles.Rows)
                            {
                                bool isInRole = Convert.ToBoolean(row.Cells["IsInRole"].Value);
                                if (isInRole)
                                {
                                    string roleId = row.Cells["RoleId"].Value.ToString();
                                    addRolesCommand.Parameters.Clear();
                                    addRolesCommand.Parameters.AddWithValue("@UserName", selectedUserName);
                                    addRolesCommand.Parameters.AddWithValue("@RoleId", roleId);
                                    await addRolesCommand.ExecuteNonQueryAsync();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Roles updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            await LoadUserNames();
        }

        
    }
}
