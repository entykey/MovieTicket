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
            this.lblControlName.Location = new System.Drawing.Point(60, 52);
            this.lblControlName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Size = new System.Drawing.Size(402, 48);
            this.lblControlName.TabIndex = 3;
            this.lblControlName.Text = "Danh sách ca chiếu";
            // 
            // btnUpdateShow
            // 
            this.btnUpdateShow.Location = new System.Drawing.Point(368, 94);
            this.btnUpdateShow.Name = "btnUpdateShow";
            this.btnUpdateShow.Size = new System.Drawing.Size(148, 62);
            this.btnUpdateShow.TabIndex = 42;
            this.btnUpdateShow.Text = "Update";
            this.btnUpdateShow.UseVisualStyleBackColor = true;
            this.btnUpdateShow.Click += new System.EventHandler(this.btnUpdateShow_Click);
            // 
            // btnCancelSelection
            // 
            this.btnCancelSelection.Location = new System.Drawing.Point(680, 94);
            this.btnCancelSelection.Name = "btnCancelSelection";
            this.btnCancelSelection.Size = new System.Drawing.Size(189, 62);
            this.btnCancelSelection.TabIndex = 41;
            this.btnCancelSelection.Text = "Cancel selection";
            this.btnCancelSelection.UseVisualStyleBackColor = true;
            this.btnCancelSelection.Click += new System.EventHandler(this.btnCancelSelection_Click);
            // 
            // lblShowId
            // 
            this.lblShowId.AutoSize = true;
            this.lblShowId.Location = new System.Drawing.Point(46, 244);
            this.lblShowId.Name = "lblShowId";
            this.lblShowId.Size = new System.Drawing.Size(82, 25);
            this.lblShowId.TabIndex = 40;
            this.lblShowId.Text = "ShowId";
            // 
            // txtShowId
            // 
            this.txtShowId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowId.Location = new System.Drawing.Point(237, 231);
            this.txtShowId.Name = "txtShowId";
            this.txtShowId.ReadOnly = true;
            this.txtShowId.Size = new System.Drawing.Size(404, 38);
            this.txtShowId.TabIndex = 39;
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.Location = new System.Drawing.Point(522, 94);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(152, 62);
            this.btnDeleteShow.TabIndex = 38;
            this.btnDeleteShow.Text = "Delete";
            this.btnDeleteShow.UseVisualStyleBackColor = true;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Location = new System.Drawing.Point(210, 94);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(152, 62);
            this.btnAddShow.TabIndex = 37;
            this.btnAddShow.Text = "Add";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Location = new System.Drawing.Point(237, 320);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(404, 38);
            this.dtpStartTime.TabIndex = 34;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(46, 330);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(110, 25);
            this.lblStartTime.TabIndex = 33;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(46, 288);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(177, 25);
            this.lblMovieId.TabIndex = 31;
            this.lblMovieId.Text = "Selected MovieId";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieId.Location = new System.Drawing.Point(237, 277);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.ReadOnly = true;
            this.txtMovieId.Size = new System.Drawing.Size(404, 38);
            this.txtMovieId.TabIndex = 29;
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(52, 94);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(152, 62);
            this.btnFetchData.TabIndex = 28;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // dataGv
            // 
            this.dataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGv.Location = new System.Drawing.Point(52, 423);
            this.dataGv.Name = "dataGv";
            this.dataGv.ReadOnly = true;
            this.dataGv.RowHeadersWidth = 82;
            this.dataGv.RowTemplate.Height = 33;
            this.dataGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGv.Size = new System.Drawing.Size(1192, 423);
            this.dataGv.TabIndex = 27;
            this.dataGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGv_CellClick);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Location = new System.Drawing.Point(237, 364);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(404, 38);
            this.dtpEndTime.TabIndex = 44;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(46, 373);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(103, 25);
            this.lblEndTime.TabIndex = 43;
            this.lblEndTime.Text = "End Time";
            // 
            // lblCboMovieName
            // 
            this.lblCboMovieName.AutoSize = true;
            this.lblCboMovieName.Location = new System.Drawing.Point(48, 194);
            this.lblCboMovieName.Name = "lblCboMovieName";
            this.lblCboMovieName.Size = new System.Drawing.Size(136, 25);
            this.lblCboMovieName.TabIndex = 45;
            this.lblCboMovieName.Text = "Select Movie";
            // 
            // cboMovieName
            // 
            this.cboMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovieName.FormattingEnabled = true;
            this.cboMovieName.Location = new System.Drawing.Point(237, 184);
            this.cboMovieName.Name = "cboMovieName";
            this.cboMovieName.Size = new System.Drawing.Size(404, 39);
            this.cboMovieName.TabIndex = 46;
            this.cboMovieName.SelectedIndexChanged += new System.EventHandler(this.cboMovieName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Movie Title";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTitle.Location = new System.Drawing.Point(776, 277);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.ReadOnly = true;
            this.txtMovieTitle.Size = new System.Drawing.Size(404, 38);
            this.txtMovieTitle.TabIndex = 47;
            // 
            // ucShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
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
            this.Name = "ucShows";
            this.Size = new System.Drawing.Size(1418, 1099);
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
