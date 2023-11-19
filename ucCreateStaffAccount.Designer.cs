namespace MovieTicket
{
    partial class ucCreateStaffAccount
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
            this.components = new System.ComponentModel.Container();
            this.lblControlName = new System.Windows.Forms.Label();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.lblUserNames = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
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
            this.lblControlName.Size = new System.Drawing.Size(368, 48);
            this.lblControlName.TabIndex = 5;
            this.lblControlName.Text = "Cấp TK nhân viên";
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.Location = new System.Drawing.Point(48, 113);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(244, 73);
            this.btnCreateStaff.TabIndex = 6;
            this.btnCreateStaff.Text = "Create";
            this.btnCreateStaff.UseVisualStyleBackColor = true;
            this.btnCreateStaff.Click += new System.EventHandler(this.btnCreateStaff_Click);
            // 
            // lblUserNames
            // 
            this.lblUserNames.AutoSize = true;
            this.lblUserNames.Location = new System.Drawing.Point(43, 218);
            this.lblUserNames.Name = "lblUserNames";
            this.lblUserNames.Size = new System.Drawing.Size(113, 25);
            this.lblUserNames.TabIndex = 9;
            this.lblUserNames.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(203, 205);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 38);
            this.txtUserName.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(48, 331);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 82;
            this.dgvUsers.RowTemplate.Height = 33;
            this.dgvUsers.Size = new System.Drawing.Size(1150, 275);
            this.dgvUsers.TabIndex = 11;
            // 
            // ucCreateStaffAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserNames);
            this.Controls.Add(this.btnCreateStaff);
            this.Controls.Add(this.lblControlName);
            this.Name = "ucCreateStaffAccount";
            this.Size = new System.Drawing.Size(1316, 917);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.Button btnCreateStaff;
        private System.Windows.Forms.Label lblUserNames;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}
