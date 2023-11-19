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

        #region EntityFramework entity
        public readonly CRVCinemaEntities dbContext;
        #endregion

        private List<Roles> allRoles;

        public ucAssignRole()
        {
            InitializeComponent();
            dbContext =  new CRVCinemaEntities();

            //LoadUserNames();
            //LoadAllRoles();



        }
        

        private async Task LoadUserNames()
        {
            var userNames = await dbContext.Users
                .Select(u => u.UserName)
                .ToListAsync();

            cboUserNames.DataSource = userNames;
        }

        private async Task LoadAllRoles()
        {
            allRoles = dbContext.Roles.ToList();
            //dgvRoles.DataSource = allRoles;
            dgvRoles.DataSource = allRoles.Select(r => new { r.Id, r.Name }).ToList();


            //allRoles = await dbContext.Roles.ToListAsync();
            //dgvRoles.DataSource = allRoles.Select(r => new { r.Id, r.Name, IsInRole = false }).ToList();


            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.MultiSelect = false;

            // Add checkbox column
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
            {
                ValueType = typeof(bool),
                HeaderText = "Is In Role",
                Name = "colIsInRole",
                DataPropertyName = "IsInRole"
            };
            dgvRoles.Columns.Add(checkboxColumn);
        }

        private async void cboUserNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedUserName = cboUserNames.SelectedItem?.ToString();

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

            if (!string.IsNullOrEmpty(selectedUserName))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(Globals.ConnectionString))
                    {
                        await connection.OpenAsync();

                        string query = @"
                        SELECT r.Id, r.Name, CASE WHEN ur.UserId IS NOT NULL THEN 1 ELSE 0 END AS IsInRole
                        FROM Users r
                        LEFT JOIN UserRoles ur ON r.Id = ur.RoleId AND ur.UserId = (
                            SELECT Id FROM Users WHERE UserName = @UserName
                        )";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", selectedUserName);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                dgvRoles.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            //string selectedUserName = cboUserNames.SelectedItem.ToString();
            //var selectedUser = await dbContext.Users
            //    .FirstOrDefaultAsync(u => u.UserName == selectedUserName);

            //if (selectedUser != null)
            //{
            //    // Update user roles based on checkbox IsAdmin
            //    bool isInAdminRole = chkbIsAdmin.Checked;

            //    if (isInAdminRole)
            //    {
            //        var adminRole = await dbContext.Roles
            //            .FirstOrDefaultAsync(u => u.Name == "Admin");

            //        dbContext.UserRoles.Add(new IdentityUserRole
            //        {
            //            UserId = selectedUser.Id,
            //            RoleId = adminRole.Id
            //        });
            //    }
            //    else
            //    {
            //        var adminRole = await dbContext.Roles
            //            .FirstOrDefaultAsync(u => u.Name == "Admin");

            //        var userRole = await dbContext.UserRoles
            //            .FirstOrDefaultAsync(ur => ur.UserId == selectedUser.Id && ur.RoleId == adminRole.Id);

            //        if (userRole != null)
            //        {
            //            dbContext.UserRoles.Remove(userRole);
            //        }
            //    }

            //    await dbContext.SaveChangesAsync();
            //    MessageBox.Show("Roles updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


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
                                bool isInRole = Convert.ToBoolean(row.Cells["colIsInRole"].Value);
                                if (isInRole)
                                {
                                    string roleId = row.Cells["Id"].Value.ToString();
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
            await LoadAllRoles();
        }

        private void ucAssignRole_Load(object sender, EventArgs e)
        {

        }
    }
}
