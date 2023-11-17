namespace MovieTicket
{
    partial class ucShows
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
            this.btnUpdateShow = new System.Windows.Forms.Button();
            this.btnCancelSelection = new System.Windows.Forms.Button();
            this.lblShowId = new System.Windows.Forms.Label();
            this.txtShowId = new System.Windows.Forms.TextBox();
            this.btnDeleteShow = new System.Windows.Forms.Button();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.dataGv = new System.Windows.Forms.DataGridView();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblCboMovieName = new System.Windows.Forms.Label();
            this.cboMovieName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGv)).BeginInit();
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
            this.lblControlName.Size = new System.Drawing.Size(270, 31);
            this.lblControlName.TabIndex = 3;
            this.lblControlName.Text = "Danh sách ca chiếu";
            // 
            // btnUpdateShow
            // 
            this.btnUpdateShow.Location = new System.Drawing.Point(245, 60);
            this.btnUpdateShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateShow.Name = "btnUpdateShow";
            this.btnUpdateShow.Size = new System.Drawing.Size(101, 40);
            this.btnUpdateShow.TabIndex = 42;
            this.btnUpdateShow.Text = "Update";
            this.btnUpdateShow.UseVisualStyleBackColor = true;
            this.btnUpdateShow.Click += new System.EventHandler(this.btnUpdateShow_Click);
            // 
            // btnCancelSelection
            // 
            this.btnCancelSelection.Location = new System.Drawing.Point(453, 60);
            this.btnCancelSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelSelection.Name = "btnCancelSelection";
            this.btnCancelSelection.Size = new System.Drawing.Size(132, 40);
            this.btnCancelSelection.TabIndex = 41;
            this.btnCancelSelection.Text = "Cancel selection";
            this.btnCancelSelection.UseVisualStyleBackColor = true;
            this.btnCancelSelection.Click += new System.EventHandler(this.btnCancelSelection_Click);
            // 
            // lblShowId
            // 
            this.lblShowId.AutoSize = true;
            this.lblShowId.Location = new System.Drawing.Point(31, 156);
            this.lblShowId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowId.Name = "lblShowId";
            this.lblShowId.Size = new System.Drawing.Size(51, 16);
            this.lblShowId.TabIndex = 40;
            this.lblShowId.Text = "ShowId";
            // 
            // txtShowId
            // 
            this.txtShowId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowId.Location = new System.Drawing.Point(158, 148);
            this.txtShowId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShowId.Name = "txtShowId";
            this.txtShowId.ReadOnly = true;
            this.txtShowId.Size = new System.Drawing.Size(271, 27);
            this.txtShowId.TabIndex = 39;
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.Location = new System.Drawing.Point(348, 60);
            this.btnDeleteShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(101, 40);
            this.btnDeleteShow.TabIndex = 38;
            this.btnDeleteShow.Text = "Delete";
            this.btnDeleteShow.UseVisualStyleBackColor = true;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Location = new System.Drawing.Point(140, 60);
            this.btnAddShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(101, 40);
            this.btnAddShow.TabIndex = 37;
            this.btnAddShow.Text = "Add";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Location = new System.Drawing.Point(158, 205);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(271, 27);
            this.dtpStartTime.TabIndex = 34;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(31, 211);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(68, 16);
            this.lblStartTime.TabIndex = 33;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(31, 184);
            this.lblMovieId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(112, 16);
            this.lblMovieId.TabIndex = 31;
            this.lblMovieId.Text = "Selected MovieId";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieId.Location = new System.Drawing.Point(158, 177);
            this.txtMovieId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(271, 27);
            this.txtMovieId.TabIndex = 29;
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(35, 60);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(101, 40);
            this.btnFetchData.TabIndex = 28;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // dataGv
            // 
            this.dataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGv.Location = new System.Drawing.Point(35, 271);
            this.dataGv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGv.Name = "dataGv";
            this.dataGv.RowHeadersWidth = 82;
            this.dataGv.RowTemplate.Height = 33;
            this.dataGv.Size = new System.Drawing.Size(795, 271);
            this.dataGv.TabIndex = 27;
            this.dataGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGv_CellClick);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Location = new System.Drawing.Point(158, 233);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(271, 27);
            this.dtpEndTime.TabIndex = 44;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(31, 239);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(65, 16);
            this.lblEndTime.TabIndex = 43;
            this.lblEndTime.Text = "End Time";
            // 
            // lblCboMovieName
            // 
            this.lblCboMovieName.AutoSize = true;
            this.lblCboMovieName.Location = new System.Drawing.Point(32, 124);
            this.lblCboMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCboMovieName.Name = "lblCboMovieName";
            this.lblCboMovieName.Size = new System.Drawing.Size(85, 16);
            this.lblCboMovieName.TabIndex = 45;
            this.lblCboMovieName.Text = "Select Movie";
            // 
            // cboMovieName
            // 
            this.cboMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovieName.FormattingEnabled = true;
            this.cboMovieName.Location = new System.Drawing.Point(158, 118);
            this.cboMovieName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMovieName.Name = "cboMovieName";
            this.cboMovieName.Size = new System.Drawing.Size(271, 28);
            this.cboMovieName.TabIndex = 46;
            this.cboMovieName.SelectedIndexChanged += new System.EventHandler(this.cboMovieName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Movie Title";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTitle.Location = new System.Drawing.Point(517, 177);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(271, 27);
            this.txtMovieTitle.TabIndex = 47;
            // 
            // ucShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.cboMovieName);
            this.Controls.Add(this.lblCboMovieName);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.btnUpdateShow);
            this.Controls.Add(this.btnCancelSelection);
            this.Controls.Add(this.lblShowId);
            this.Controls.Add(this.txtShowId);
            this.Controls.Add(this.btnDeleteShow);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblMovieId);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.dataGv);
            this.Controls.Add(this.lblControlName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucShows";
            this.Size = new System.Drawing.Size(877, 587);
            this.Load += new System.EventHandler(this.ucShows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.Button btnUpdateShow;
        private System.Windows.Forms.Button btnCancelSelection;
        private System.Windows.Forms.Label lblShowId;
        private System.Windows.Forms.TextBox txtShowId;
        private System.Windows.Forms.Button btnDeleteShow;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.DataGridView dataGv;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblCboMovieName;
        private System.Windows.Forms.ComboBox cboMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieTitle;
    }
}
