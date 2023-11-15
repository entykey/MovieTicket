namespace MovieTicket
{
    partial class ucMovies
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
            this.dataGv = new System.Windows.Forms.DataGridView();
            this.btnFetchData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlName
            // 
            this.lblControlName.AutoSize = true;
            this.lblControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlName.ForeColor = System.Drawing.Color.Indigo;
            this.lblControlName.Location = new System.Drawing.Point(41, 33);
            this.lblControlName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Size = new System.Drawing.Size(334, 48);
            this.lblControlName.TabIndex = 3;
            this.lblControlName.Text = "Danh sách phim";
            // 
            // dataGv
            // 
            this.dataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGv.Location = new System.Drawing.Point(49, 215);
            this.dataGv.Name = "dataGv";
            this.dataGv.RowHeadersWidth = 82;
            this.dataGv.RowTemplate.Height = 33;
            this.dataGv.Size = new System.Drawing.Size(1193, 503);
            this.dataGv.TabIndex = 10;
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(49, 114);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(151, 70);
            this.btnFetchData.TabIndex = 11;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // ucMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.dataGv);
            this.Controls.Add(this.lblControlName);
            this.Name = "ucMovies";
            this.Size = new System.Drawing.Size(1316, 917);
            ((System.ComponentModel.ISupportInitialize)(this.dataGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.DataGridView dataGv;
        private System.Windows.Forms.Button btnFetchData;
    }
}
