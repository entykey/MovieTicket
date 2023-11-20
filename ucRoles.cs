namespace MovieTicket
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using MovieTicket.EFModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ucRoles : UserControl
    {
        private static ucRoles _instance;

        public static ucRoles Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRoles();
                return _instance;
            }
        }

        #region EntityFramework entity
        public readonly CRVCinemaEntities dbContext;
        #endregion


        public ucRoles()
        {
            InitializeComponent();
            dbContext = new CRVCinemaEntities();

            this.btnDeleteRole.Enabled = false;
            this.btnUpdateRole.Enabled = false;
            this.btnCancelSelection.Enabled = false;
        }
        private async void ucRoles_Load(object sender, EventArgs e)
        {
            await LoadRoles();
        }


        #region database operations
        private async Task LoadRoles()
        {
            var roles = await dbContext.Roles
                .ToListAsync();

            dgvRoles.DataSource = roles;
        }
        public async Task AddRole()
        {
            // Add a new role to the database
            var roleName = txtRoleName.Text;

            if (!string.IsNullOrEmpty(roleName))
            {
                dbContext.Roles.Add(new Roles { Id = Guid.NewGuid().ToString(), Name = roleName, NormalizedName = roleName.ToUpper() });
                await dbContext.SaveChangesAsync();
                await LoadRoles(); // Reload roles in the DataGridView
                MessageBox.Show("Role đã được tạo thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a role name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task UpdateRole()
        {
            // Find the movie in the database
            Roles roleToUpdate = dbContext.Roles.Find(txtRoleId.Text);

            if (roleToUpdate != null)
            {
                // Update the movie properties
                roleToUpdate.Name = txtRoleName.Text;

                // Save the changes to the database
                await Task.FromResult(dbContext.SaveChanges());

                // Re-fetch and update the DataGridView
                await LoadRoles();
                MessageBox.Show("Role đã được cập nhật thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public async Task DeleteRole()
        {

            // Delete the selected role from the database
            var selectedRole = dgvRoles.CurrentRow?.DataBoundItem as Roles;

            if (selectedRole != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Role này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dbContext.Roles.Remove(selectedRole);
                    await dbContext.SaveChangesAsync();
                    await LoadRoles(); // Reload roles in the DataGridView
                    btnAddRole.Enabled = true;
                    txtRoleId.Text = "";
                    txtRoleName.Text = "";
                    btnUpdateRole.Enabled = false;
                    btnDeleteRole.Enabled = false;
                    MessageBox.Show("Role đã được xóa thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a role to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region form events
        private void dataGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 13)  // ignore header row and any column
                return;

            txtRoleId.Text = dgvRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoleName.Text = dgvRoles.Rows[e.RowIndex].Cells[1].Value.ToString();

            
            this.btnAddRole.Enabled = false;
            //this.btnUpdate.Enabled = true;
            this.btnDeleteRole.Enabled = true;
            this.btnUpdateRole.Enabled = true;
            this.btnCancelSelection.Enabled = true;
        }
        #endregion


        #region button events
        private async void btnAddRole_Click(object sender, EventArgs e)
        {
            await AddRole();
        }
        
        private async void btnDeleteRole_Click(object sender, EventArgs e)
        {
            await DeleteRole();
        }

        private async void btnUpdateRole_Click(object sender, EventArgs e)
        {
            await UpdateRole();
        }
        private void btnCancelSelection_Click(object sender, EventArgs e)
        {
            btnAddRole.Enabled = true;
            txtRoleId.Text = "";
            txtRoleName.Text = "";
            btnUpdateRole.Enabled = false;
            btnDeleteRole.Enabled = false;
        }
        #endregion
    }
}
