namespace MovieTicket
{
    partial class ucAssignRole
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
            this.cboUserNames = new System.Windows.Forms.ComboBox();
            this.lblUserNames = new System.Windows.Forms.Label();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlName
            // 
            this.lblControlName.AutoSize = true;
            this.lblControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlName.ForeColor = System.Drawing.Color.Indigo;
            this.lblControlName.Location = new System.Drawing.Point(27, 21);
            this.lblControlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Size = new System.Drawing.Size(185, 31);
            this.lblControlName.TabIndex = 4;
            this.lblControlName.Text = "Assign Roles";
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(32, 211);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersWidth = 82;
            this.dgvRoles.RowTemplate.Height = 33;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(706, 182);
            this.dgvRoles.TabIndex = 5;
            // 
            // cboUserNames
            // 
            this.cboUserNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserNames.FormattingEnabled = true;
            this.cboUserNames.Location = new System.Drawing.Point(219, 119);
            this.cboUserNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUserNames.Name = "cboUserNames";
            this.cboUserNames.Size = new System.Drawing.Size(195, 28);
            this.cboUserNames.TabIndex = 6;
            this.cboUserNames.SelectedIndexChanged += new System.EventHandler(this.cboUserNames_SelectedIndexChanged);
            // 
            // lblUserNames
            // 
            this.lblUserNames.AutoSize = true;
            this.lblUserNames.Location = new System.Drawing.Point(32, 125);
            this.lblUserNames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNames.Name = "lblUserNames";
            this.lblUserNames.Size = new System.Drawing.Size(166, 16);
            this.lblUserNames.TabIndex = 7;
            this.lblUserNames.Text = "Cấp quyền cho UserName";
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(137, 65);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(101, 40);
            this.btnUpdateRole.TabIndex = 7;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(32, 65);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(101, 40);
            this.btnFetchData.TabIndex = 33;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(32, 171);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(267, 18);
            this.lblInstruction.TabIndex = 34;
            this.lblInstruction.Text = "Tick vào quyền cần cấp và click Update";
            // 
            // ucAssignRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.lblUserNames);
            this.Controls.Add(this.cboUserNames);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.lblControlName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucAssignRole";
            this.Size = new System.Drawing.Size(945, 703);
            this.Load += new System.EventHandler(this.ucAssignRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.ComboBox cboUserNames;
        private System.Windows.Forms.Label lblUserNames;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Label lblInstruction;
    }
}
