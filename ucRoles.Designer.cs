namespace MovieTicket
{
    partial class ucRoles
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblControlName = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnCancelSelection = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.txtRoleId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlName
            // 
            this.lblControlName.AutoSize = true;
            this.lblControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlName.ForeColor = System.Drawing.Color.Indigo;
            this.lblControlName.Location = new System.Drawing.Point(40, 33);
            this.lblControlName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Size = new System.Drawing.Size(132, 48);
            this.lblControlName.TabIndex = 3;
            this.lblControlName.Text = "Roles";
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(48, 366);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 82;
            this.dgvRoles.RowTemplate.Height = 33;
            this.dgvRoles.Size = new System.Drawing.Size(1163, 338);
            this.dgvRoles.TabIndex = 4;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGv_CellClick);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(361, 96);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(152, 62);
            this.btnUpdateRole.TabIndex = 31;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnCancelSelection
            // 
            this.btnCancelSelection.Location = new System.Drawing.Point(673, 96);
            this.btnCancelSelection.Name = "btnCancelSelection";
            this.btnCancelSelection.Size = new System.Drawing.Size(198, 62);
            this.btnCancelSelection.TabIndex = 30;
            this.btnCancelSelection.Text = "Cancel selection";
            this.btnCancelSelection.UseVisualStyleBackColor = true;
            this.btnCancelSelection.Click += new System.EventHandler(this.btnCancelSelection_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(516, 96);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(152, 62);
            this.btnDeleteRole.TabIndex = 29;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(204, 96);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(152, 62);
            this.btnAddRole.TabIndex = 28;
            this.btnAddRole.Text = "Add";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(48, 96);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(152, 62);
            this.btnFetchData.TabIndex = 27;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(48, 235);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(112, 25);
            this.lblRoleName.TabIndex = 33;
            this.lblRoleName.Text = "RoleName";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(200, 223);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(405, 38);
            this.txtRoleName.TabIndex = 32;
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(48, 192);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(73, 25);
            this.lblMovieId.TabIndex = 35;
            this.lblMovieId.Text = "RoleId";
            // 
            // txtRoleId
            // 
            this.txtRoleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleId.Location = new System.Drawing.Point(200, 179);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.ReadOnly = true;
            this.txtRoleId.Size = new System.Drawing.Size(405, 38);
            this.txtRoleId.TabIndex = 34;
            // 
            // ucRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMovieId);
            this.Controls.Add(this.txtRoleId);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.btnCancelSelection);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.lblControlName);
            this.Name = "ucRoles";
            this.Size = new System.Drawing.Size(1418, 1099);
            this.Load += new System.EventHandler(this.ucRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnCancelSelection;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.TextBox txtRoleId;
    }
}
