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
            this.lblCmbMovies = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.ComboBox();

            this.label3 = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOrdered = new System.Windows.Forms.ComboBox();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnRemoveFoodAll = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.23881F));

            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 514);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);

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
            this.lblControlName.Location = new System.Drawing.Point(40, 33);
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

            this.panel1.Location = new System.Drawing.Point(36, 443);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);

            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 72);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 12);
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

            this.lblTotalPrice.Location = new System.Drawing.Point(28, 335);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(191, 37);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // btnBookNow
            // 

            this.btnBookNow.Location = new System.Drawing.Point(36, 381);
            this.btnBookNow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(91, 34);

            this.btnBookNow.TabIndex = 5;
            this.btnBookNow.Text = "Book Now !";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnCancel
            // 

            this.btnCancel.Location = new System.Drawing.Point(174, 381);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);

            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAvailable
            // 
            this.panelAvailable.BackColor = System.Drawing.Color.White;
            this.panelAvailable.Location = new System.Drawing.Point(52, 98);
            this.panelAvailable.Name = "panelAvailable";
            this.panelAvailable.Size = new System.Drawing.Size(46, 44);
            this.panelAvailable.TabIndex = 7;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(104, 109);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(100, 25);
            this.lblAvailable.TabIndex = 8;
            this.lblAvailable.Text = "Available";
            // 
            // lblBeingBooked
            // 
            this.lblBeingBooked.AutoSize = true;
            this.lblBeingBooked.Location = new System.Drawing.Point(278, 109);
            this.lblBeingBooked.Name = "lblBeingBooked";
            this.lblBeingBooked.Size = new System.Drawing.Size(146, 25);
            this.lblBeingBooked.TabIndex = 9;
            this.lblBeingBooked.Text = "Being Booked";
            // 
            // panelBeingBooked
            // 
            this.panelBeingBooked.BackColor = System.Drawing.Color.Yellow;
            this.panelBeingBooked.Location = new System.Drawing.Point(224, 98);
            this.panelBeingBooked.Name = "panelBeingBooked";
            this.panelBeingBooked.Size = new System.Drawing.Size(46, 44);
            this.panelBeingBooked.TabIndex = 8;
            // 
            // panelBooked
            // 
            this.panelBooked.BackColor = System.Drawing.Color.Gray;
            this.panelBooked.Location = new System.Drawing.Point(440, 98);
            this.panelBooked.Name = "panelBooked";
            this.panelBooked.Size = new System.Drawing.Size(46, 44);
            this.panelBooked.TabIndex = 9;
            // 
            // lblBooked
            // 
            this.lblBooked.AutoSize = true;
            this.lblBooked.Location = new System.Drawing.Point(494, 109);
            this.lblBooked.Name = "lblBooked";
            this.lblBooked.Size = new System.Drawing.Size(85, 25);
            this.lblBooked.TabIndex = 10;
            this.lblBooked.Text = "Booked";
            // 
            // cmbMovies
            // 
            this.cmbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(175, 172);
            this.cmbMovies.Name = "cmbMovies";

            this.cmbMovies.Size = new System.Drawing.Size(288, 30);

            this.cmbMovies.TabIndex = 11;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // lblBookedSeats
            // 

            this.lblBookedSeats.Location = new System.Drawing.Point(33, 264);
            this.lblBookedSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookedSeats.Name = "lblBookedSeats";
            this.lblBookedSeats.Size = new System.Drawing.Size(465, 61);

            this.lblBookedSeats.TabIndex = 12;
            this.lblBookedSeats.Text = "Booked seats (ghế):";
            // 
            // lblCmbMovies
            // 
            this.lblCmbMovies.AutoSize = true;
            this.lblCmbMovies.Location = new System.Drawing.Point(48, 184);
            this.lblCmbMovies.Name = "lblCmbMovies";
            this.lblCmbMovies.Size = new System.Drawing.Size(121, 25);
            this.lblCmbMovies.TabIndex = 13;
            this.lblCmbMovies.Text = "Chọn phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(33, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn suất:";
            // 
            // cbShow
            // 
            this.cbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShow.FormattingEnabled = true;

            this.cbShow.Location = new System.Drawing.Point(136, 160);
            this.cbShow.Margin = new System.Windows.Forms.Padding(2);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(288, 30);
            this.cbShow.TabIndex = 14;
            this.cbShow.SelectedIndexChanged += new System.EventHandler(this.cbShow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đồ ăn thêm";
            // 
            // cbFood
            // 
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(542, 110);
            this.cbFood.Margin = new System.Windows.Forms.Padding(2);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(288, 30);
            this.cbFood.TabIndex = 16;
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(739, 159);
            this.btnFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(91, 34);
            this.btnFood.TabIndex = 18;
            this.btnFood.Text = "Add";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(33, 218);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(2);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(91, 34);
            this.btnFetch.TabIndex = 19;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ordered:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbOrdered
            // 
            this.cbOrdered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdered.FormattingEnabled = true;
            this.cbOrdered.Location = new System.Drawing.Point(542, 210);
            this.cbOrdered.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrdered.Name = "cbOrdered";
            this.cbOrdered.Size = new System.Drawing.Size(288, 30);
            this.cbOrdered.TabIndex = 23;
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.Location = new System.Drawing.Point(739, 264);
            this.btnRemoveFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(91, 34);
            this.btnRemoveFood.TabIndex = 24;
            this.btnRemoveFood.Text = "Remove";
            this.btnRemoveFood.UseVisualStyleBackColor = true;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // btnRemoveFoodAll
            // 
            this.btnRemoveFoodAll.Location = new System.Drawing.Point(542, 264);
            this.btnRemoveFoodAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFoodAll.Name = "btnRemoveFoodAll";
            this.btnRemoveFoodAll.Size = new System.Drawing.Size(91, 34);
            this.btnRemoveFoodAll.TabIndex = 25;
            this.btnRemoveFoodAll.Text = "Remove All";
            this.btnRemoveFoodAll.UseVisualStyleBackColor = true;
            this.btnRemoveFoodAll.Click += new System.EventHandler(this.btnRemoveFoodAll_Click);

            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;

            this.Controls.Add(this.btnRemoveFoodAll);
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.cbOrdered);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFood);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.lblCmbMovies);
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

            this.Size = new System.Drawing.Size(893, 692);

            this.Load += new System.EventHandler(this.ucBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
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
        private System.Windows.Forms.Label lblCmbMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShow;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOrdered;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Button btnRemoveFoodAll;

    }
}
