﻿namespace MovieTicket
{
    partial class ucFoodDrink
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtFoodDrinkId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFoodDrinkName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancelSelection = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblControlName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pbFoodDrink = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 122);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 16);
            this.lblId.TabIndex = 46;
            this.lblId.Text = "FoodDrinkId";
            // 
            // txtFoodDrinkId
            // 
            this.txtFoodDrinkId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodDrinkId.Location = new System.Drawing.Point(132, 114);
            this.txtFoodDrinkId.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodDrinkId.Name = "txtFoodDrinkId";
            this.txtFoodDrinkId.ReadOnly = true;
            this.txtFoodDrinkId.Size = new System.Drawing.Size(271, 27);
            this.txtFoodDrinkId.TabIndex = 45;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 150);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name";
            // 
            // txtFoodDrinkName
            // 
            this.txtFoodDrinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodDrinkName.Location = new System.Drawing.Point(132, 142);
            this.txtFoodDrinkName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodDrinkName.Name = "txtFoodDrinkName";
            this.txtFoodDrinkName.Size = new System.Drawing.Size(271, 27);
            this.txtFoodDrinkName.TabIndex = 43;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 61);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 40);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancelSelection
            // 
            this.btnCancelSelection.Location = new System.Drawing.Point(447, 61);
            this.btnCancelSelection.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelSelection.Name = "btnCancelSelection";
            this.btnCancelSelection.Size = new System.Drawing.Size(132, 40);
            this.btnCancelSelection.TabIndex = 41;
            this.btnCancelSelection.Text = "Cancel selection";
            this.btnCancelSelection.UseVisualStyleBackColor = true;
            this.btnCancelSelection.Click += new System.EventHandler(this.btnCancelSelection_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(343, 61);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 40);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 61);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 40);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(31, 61);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(2);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(101, 40);
            this.btnFetchData.TabIndex = 38;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(31, 258);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(775, 249);
            this.dgv.TabIndex = 37;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lblControlName
            // 
            this.lblControlName.AutoSize = true;
            this.lblControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlName.ForeColor = System.Drawing.Color.Indigo;
            this.lblControlName.Location = new System.Drawing.Point(27, 21);
            this.lblControlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Size = new System.Drawing.Size(163, 31);
            this.lblControlName.TabIndex = 36;
            this.lblControlName.Text = "Đồ ăn thêm";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(31, 178);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 48;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(132, 170);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(271, 27);
            this.txtPrice.TabIndex = 44;
            // 
            // pbFoodDrink
            // 
            this.pbFoodDrink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbFoodDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoodDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoodDrink.Location = new System.Drawing.Point(665, 61);
            this.pbFoodDrink.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoodDrink.Name = "pbFoodDrink";
            this.pbFoodDrink.Size = new System.Drawing.Size(142, 136);
            this.pbFoodDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodDrink.TabIndex = 49;
            this.pbFoodDrink.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(665, 202);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(141, 40);
            this.btnUpload.TabIndex = 45;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ucFoodDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbFoodDrink);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtFoodDrinkId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFoodDrinkName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancelSelection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblControlName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucFoodDrink";
            this.Size = new System.Drawing.Size(945, 703);
            this.Load += new System.EventHandler(this.ucFoodDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtFoodDrinkId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFoodDrinkName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancelSelection;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox pbFoodDrink;
        private System.Windows.Forms.Button btnUpload;
    }
}
