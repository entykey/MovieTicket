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
            this.lblFood = new System.Windows.Forms.Label();
            this.lblFoodDrink = new System.Windows.Forms.Label();
            this.cmbFoodDrink = new System.Windows.Forms.ComboBox();
            this.pbFoodDrink = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
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
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 492);
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
            this.panel1.Location = new System.Drawing.Point(44, 381);
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
            this.lblTotalPrice.Location = new System.Drawing.Point(44, 269);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(191, 37);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnBookNow
            // 
            this.btnBookNow.Location = new System.Drawing.Point(48, 309);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(186, 53);
            this.btnBookNow.TabIndex = 5;
            this.btnBookNow.Text = "Book Now !";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 309);
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
            this.cmbMovies.Size = new System.Drawing.Size(404, 39);
            this.cmbMovies.TabIndex = 11;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // lblBookedSeats
            // 
            this.lblBookedSeats.AutoSize = true;
            this.lblBookedSeats.Location = new System.Drawing.Point(48, 228);
            this.lblBookedSeats.Name = "lblBookedSeats";
            this.lblBookedSeats.Size = new System.Drawing.Size(205, 25);
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
            this.label2.Location = new System.Drawing.Point(605, 183);
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
            this.cbShow.Location = new System.Drawing.Point(727, 171);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(349, 41);
            this.cbShow.TabIndex = 14;
            this.cbShow.SelectedIndexChanged += new System.EventHandler(this.cbShow_SelectedIndexChanged);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.Indigo;
            this.lblFood.Location = new System.Drawing.Point(1085, 33);
            this.lblFood.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(363, 48);
            this.lblFood.TabIndex = 16;
            this.lblFood.Text = "Đồ ăn / thức uống";
            // 
            // lblFoodDrink
            // 
            this.lblFoodDrink.AutoSize = true;
            this.lblFoodDrink.Location = new System.Drawing.Point(1124, 181);
            this.lblFoodDrink.Name = "lblFoodDrink";
            this.lblFoodDrink.Size = new System.Drawing.Size(116, 25);
            this.lblFoodDrink.TabIndex = 18;
            this.lblFoodDrink.Text = "Chọn món:";
            // 
            // cmbFoodDrink
            // 
            this.cmbFoodDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFoodDrink.FormattingEnabled = true;
            this.cmbFoodDrink.Location = new System.Drawing.Point(1251, 169);
            this.cmbFoodDrink.Name = "cmbFoodDrink";
            this.cmbFoodDrink.Size = new System.Drawing.Size(399, 39);
            this.cmbFoodDrink.TabIndex = 17;
            this.cmbFoodDrink.SelectedIndexChanged += new System.EventHandler(this.cmbFoodDrink_SelectedIndexChanged);
            // 
            // pbFoodDrink
            // 
            this.pbFoodDrink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbFoodDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoodDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoodDrink.Location = new System.Drawing.Point(1251, 236);
            this.pbFoodDrink.Margin = new System.Windows.Forms.Padding(6);
            this.pbFoodDrink.Name = "pbFoodDrink";
            this.pbFoodDrink.Size = new System.Drawing.Size(399, 399);
            this.pbFoodDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodDrink.TabIndex = 19;
            this.pbFoodDrink.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(1124, 671);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 50;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1251, 662);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(399, 40);
            this.txtPrice.TabIndex = 49;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(1124, 717);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(1251, 709);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 38);
            this.nudQuantity.TabIndex = 53;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.pbFoodDrink);
            this.Controls.Add(this.lblFoodDrink);
            this.Controls.Add(this.cmbFoodDrink);
            this.Controls.Add(this.lblFood);
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
            this.Size = new System.Drawing.Size(1863, 1299);
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
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblFoodDrink;
        private System.Windows.Forms.ComboBox cmbFoodDrink;
        private System.Windows.Forms.PictureBox pbFoodDrink;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}
