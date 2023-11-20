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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBooking));
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
            this.pbFoodDrink = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.rtxtPreview = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodDrink)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.23881F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 803);
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
            this.panel1.Location = new System.Drawing.Point(54, 692);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 72);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 12);
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
            this.lblTotalPrice.Location = new System.Drawing.Point(42, 523);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(191, 37);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnBookNow
            // 
            this.btnBookNow.Location = new System.Drawing.Point(54, 595);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(136, 53);
            this.btnBookNow.TabIndex = 5;
            this.btnBookNow.Text = "Book Now !";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 595);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAvailable
            // 
            this.panelAvailable.BackColor = System.Drawing.Color.White;
            this.panelAvailable.Location = new System.Drawing.Point(54, 98);
            this.panelAvailable.Name = "panelAvailable";
            this.panelAvailable.Size = new System.Drawing.Size(46, 44);
            this.panelAvailable.TabIndex = 7;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(106, 109);
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
            this.panelBeingBooked.Location = new System.Drawing.Point(226, 98);
            this.panelBeingBooked.Name = "panelBeingBooked";
            this.panelBeingBooked.Size = new System.Drawing.Size(46, 44);
            this.panelBeingBooked.TabIndex = 8;
            // 
            // panelBooked
            // 
            this.panelBooked.BackColor = System.Drawing.Color.Gray;
            this.panelBooked.Location = new System.Drawing.Point(442, 98);
            this.panelBooked.Name = "panelBooked";
            this.panelBooked.Size = new System.Drawing.Size(46, 44);
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
            this.cmbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(204, 172);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(430, 41);
            this.cmbMovies.TabIndex = 11;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // lblBookedSeats
            // 
            this.lblBookedSeats.Location = new System.Drawing.Point(50, 412);
            this.lblBookedSeats.Name = "lblBookedSeats";
            this.lblBookedSeats.Size = new System.Drawing.Size(698, 95);
            this.lblBookedSeats.TabIndex = 12;
            this.lblBookedSeats.Text = "Booked seats (ghế):";
            // 
            // lblCmbMovies
            // 
            this.lblCmbMovies.AutoSize = true;
            this.lblCmbMovies.Location = new System.Drawing.Point(50, 184);
            this.lblCmbMovies.Name = "lblCmbMovies";
            this.lblCmbMovies.Size = new System.Drawing.Size(121, 25);
            this.lblCmbMovies.TabIndex = 13;
            this.lblCmbMovies.Text = "Chọn phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 262);
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
            this.cbShow.Location = new System.Drawing.Point(204, 250);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(430, 41);
            this.cbShow.TabIndex = 14;
            this.cbShow.SelectedIndexChanged += new System.EventHandler(this.cbShow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đồ ăn thêm";
            // 
            // cbFood
            // 
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(813, 172);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(430, 41);
            this.cbFood.TabIndex = 16;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(1109, 231);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(136, 53);
            this.btnFood.TabIndex = 18;
            this.btnFood.Text = "Add";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(50, 341);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(136, 53);
            this.btnFetch.TabIndex = 19;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ordered:";
            // 
            // cbOrdered
            // 
            this.cbOrdered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdered.FormattingEnabled = true;
            this.cbOrdered.Location = new System.Drawing.Point(815, 300);
            this.cbOrdered.Name = "cbOrdered";
            this.cbOrdered.Size = new System.Drawing.Size(430, 41);
            this.cbOrdered.TabIndex = 23;
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.Location = new System.Drawing.Point(1064, 358);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(179, 53);
            this.btnRemoveFood.TabIndex = 24;
            this.btnRemoveFood.Text = "Remove";
            this.btnRemoveFood.UseVisualStyleBackColor = true;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // btnRemoveFoodAll
            // 
            this.btnRemoveFoodAll.Location = new System.Drawing.Point(812, 358);
            this.btnRemoveFoodAll.Name = "btnRemoveFoodAll";
            this.btnRemoveFoodAll.Size = new System.Drawing.Size(188, 53);
            this.btnRemoveFoodAll.TabIndex = 25;
            this.btnRemoveFoodAll.Text = "Remove All";
            this.btnRemoveFoodAll.UseVisualStyleBackColor = true;
            this.btnRemoveFoodAll.Click += new System.EventHandler(this.btnRemoveFoodAll_Click);
            // 
            // pbFoodDrink
            // 
            this.pbFoodDrink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbFoodDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoodDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoodDrink.Location = new System.Drawing.Point(812, 429);
            this.pbFoodDrink.Margin = new System.Windows.Forms.Padding(6);
            this.pbFoodDrink.Name = "pbFoodDrink";
            this.pbFoodDrink.Size = new System.Drawing.Size(240, 240);
            this.pbFoodDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodDrink.TabIndex = 50;
            this.pbFoodDrink.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // rtxtPreview
            // 
            this.rtxtPreview.Location = new System.Drawing.Point(23, 47);
            this.rtxtPreview.Name = "rtxtPreview";
            this.rtxtPreview.Size = new System.Drawing.Size(505, 610);
            this.rtxtPreview.TabIndex = 51;
            this.rtxtPreview.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.rtxtPreview);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1287, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 776);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview vé";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(186, 678);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 72);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "In vé";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbFoodDrink);
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
            this.Size = new System.Drawing.Size(2307, 1081);
            this.Load += new System.EventHandler(this.ucBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodDrink)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pbFoodDrink;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox rtxtPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}