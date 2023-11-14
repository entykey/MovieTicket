namespace MovieTicket
{
    partial class ucBooking
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblControlName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelAvailable = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblBeingBooked = new System.Windows.Forms.Label();
            this.panelBeingBooked = new System.Windows.Forms.Panel();
            this.panelBooked = new System.Windows.Forms.Panel();
            this.lblBooked = new System.Windows.Forms.Label();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.lblBookedSeats = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.23881F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 514);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblControlName
            // 
            this.lblControlName.AutoSize = true;
            this.lblControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlName.ForeColor = System.Drawing.Color.Indigo;
            this.lblControlName.Location = new System.Drawing.Point(41, 33);
            this.lblControlName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Size = new System.Drawing.Size(155, 48);
            this.lblControlName.TabIndex = 2;
            this.lblControlName.Text = "Bán vé";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 83);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Màn Ảnh";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalPrice.Location = new System.Drawing.Point(47, 264);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(191, 37);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnBookNow
            // 
            this.btnBookNow.Location = new System.Drawing.Point(49, 304);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(186, 53);
            this.btnBookNow.TabIndex = 5;
            this.btnBookNow.Text = "Book Now !";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAvailable
            // 
            this.panelAvailable.BackColor = System.Drawing.Color.White;
            this.panelAvailable.Location = new System.Drawing.Point(54, 99);
            this.panelAvailable.Name = "panelAvailable";
            this.panelAvailable.Size = new System.Drawing.Size(47, 44);
            this.panelAvailable.TabIndex = 7;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(107, 109);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(100, 25);
            this.lblAvailable.TabIndex = 8;
            this.lblAvailable.Text = "Available";
            // 
            // lblBeingBooked
            // 
            this.lblBeingBooked.AutoSize = true;
            this.lblBeingBooked.Location = new System.Drawing.Point(280, 109);
            this.lblBeingBooked.Name = "lblBeingBooked";
            this.lblBeingBooked.Size = new System.Drawing.Size(146, 25);
            this.lblBeingBooked.TabIndex = 9;
            this.lblBeingBooked.Text = "Being Booked";
            // 
            // panelBeingBooked
            // 
            this.panelBeingBooked.BackColor = System.Drawing.Color.Yellow;
            this.panelBeingBooked.Location = new System.Drawing.Point(227, 99);
            this.panelBeingBooked.Name = "panelBeingBooked";
            this.panelBeingBooked.Size = new System.Drawing.Size(47, 44);
            this.panelBeingBooked.TabIndex = 8;
            // 
            // panelBooked
            // 
            this.panelBooked.BackColor = System.Drawing.Color.Gray;
            this.panelBooked.Location = new System.Drawing.Point(443, 99);
            this.panelBooked.Name = "panelBooked";
            this.panelBooked.Size = new System.Drawing.Size(47, 44);
            this.panelBooked.TabIndex = 9;
            // 
            // lblBooked
            // 
            this.lblBooked.AutoSize = true;
            this.lblBooked.Location = new System.Drawing.Point(496, 109);
            this.lblBooked.Name = "lblBooked";
            this.lblBooked.Size = new System.Drawing.Size(85, 25);
            this.lblBooked.TabIndex = 10;
            this.lblBooked.Text = "Booked";
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(285, 181);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(289, 33);
            this.cmbMovies.TabIndex = 11;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged_1);
            // 
            // lblBookedSeats
            // 
            this.lblBookedSeats.AutoSize = true;
            this.lblBookedSeats.Location = new System.Drawing.Point(49, 228);
            this.lblBookedSeats.Name = "lblBookedSeats";
            this.lblBookedSeats.Size = new System.Drawing.Size(149, 25);
            this.lblBookedSeats.TabIndex = 12;
            this.lblBookedSeats.Text = "Booked seats:";
            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lblBookedSeats);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.lblBooked);
            this.Controls.Add(this.panelBooked);
            this.Controls.Add(this.panelBeingBooked);
            this.Controls.Add(this.lblBeingBooked);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.panelAvailable);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblControlName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucBooking";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1316, 917);
            this.Load += new System.EventHandler(this.ucBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblBeingBooked;
        private System.Windows.Forms.Panel panelBeingBooked;
        private System.Windows.Forms.Panel panelBooked;
        private System.Windows.Forms.Label lblBooked;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.Label lblBookedSeats;
    }
}
