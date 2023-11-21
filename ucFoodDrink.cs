namespace MovieTicket
{
    using MovieTicket.EFModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;



    public partial class ucFoodDrink : UserControl
    {
        private static ucFoodDrink _instance;

        public static ucFoodDrink Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucFoodDrink();
                return _instance;
            }
        }

        #region EntityFramework entity
        public readonly CRVCinemaEntities dbContext;
        #endregion

        public ucFoodDrink()
        {
            InitializeComponent();
            dbContext = new CRVCinemaEntities();

            this.btnDelete.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnCancelSelection.Enabled = false;
            this.pbFoodDrink.Image = null;
        }

        #region form events
        private void ucFoodDrink_Load(object sender, EventArgs e)
        {

        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 13)  // ignore header row and any column
                return;

            txtFoodDrinkId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFoodDrinkName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();

            // Check if the cell value is null before converting to decimal
            if (dgv.Rows[e.RowIndex].Cells[3].Value != null)
            {
                txtPrice.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                txtPrice.Text = "";
            }

            // Get the selected item
            var selectedItem = dgv.Rows[e.RowIndex].DataBoundItem as FoodDrinks;

            // Check if the selected item has an image path
            if (!string.IsNullOrEmpty(selectedItem?.ImagePath))
            {
                // Load the image into the PictureBox
                string imagePath = Path.Combine("Uploaded/FoodDrink", selectedItem.ImagePath);
                pbFoodDrink.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Clear the PictureBox if there is no image path
                pbFoodDrink.Image = null;
            }

            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnCancelSelection.Enabled = true;
        }
        #endregion


        #region database operations
        private async Task LoadItem()
        {
            var roles = await dbContext.FoodDrinks
                .ToListAsync();

            dgv.DataSource = roles;
        }
        public async Task AddItem()
        {
            // Add a new item to the database
            var itemName = txtFoodDrinkName.Text;

            if (!string.IsNullOrEmpty(itemName))
            {
                decimal price = txtPrice.Text == "" ? 30000 : decimal.Parse(txtPrice.Text);

                // Create the destination folder if it doesn't exist
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploaded", "FoodDrink");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }


                if (pbFoodDrink.Image != null)
                {
                    // Generate a unique file name
                    string fileName = Path.Combine(folderPath, Guid.NewGuid().ToString() + ".jpg");

                    // Save the image to the specified path
                    pbFoodDrink.Image.Save(fileName, ImageFormat.Jpeg);

                    // Save the item to the database with the file path
                    dbContext.FoodDrinks.Add(new FoodDrinks { FoodDrinkId = Guid.NewGuid().ToString(), Name = itemName, ImagePath = fileName, Price = price });
                    await dbContext.SaveChangesAsync();
                    await LoadItem(); // Reload items in the DataGridView
                }
                else
                {
                    // Handle the case when no image is selected
                    dbContext.FoodDrinks.Add(new FoodDrinks { FoodDrinkId = Guid.NewGuid().ToString(), Name = itemName, Price = price });
                    await dbContext.SaveChangesAsync();
                    await LoadItem(); // Reload items in the DataGridView
                }

                //// Generate a unique file name
                //string fileName = Path.Combine(folderPath, Guid.NewGuid().ToString() + ".jpg");

                //// Save the image to the specified path
                //pbFoodDrink.Image.Save(fileName, ImageFormat.Jpeg);

                //// Save the item to the database with the file path
                //dbContext.FoodDrinks.Add(new FoodDrinks { FoodDrinkId = Guid.NewGuid().ToString(), Name = itemName, ImagePath = fileName, Price = price });
                //await dbContext.SaveChangesAsync();
                //await LoadItem(); // Reload items in the DataGridView
            }
            else
            {
                MessageBox.Show("Please enter an item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateItem()
        {
            // Find the movie in the database
            var itemToUpdate = dbContext.FoodDrinks.Find(txtFoodDrinkId.Text);

            if (itemToUpdate != null)
            {
                decimal price = txtPrice.Text == "" ? 30000 : decimal.Parse(txtPrice.Text);

                // Create the destination folder if it doesn't exist
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploaded", "FoodDrink");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Generate a unique file name
                string fileName = Path.Combine(folderPath, Guid.NewGuid().ToString() + ".jpg");

                // Save the image to the specified path
                pbFoodDrink.Image.Save(fileName, ImageFormat.Jpeg);

                // Update the movie properties
                itemToUpdate.Name = txtFoodDrinkName.Text;
                itemToUpdate.Price = price;
                itemToUpdate.ImagePath = fileName;

                // Save the changes to the database
                await dbContext.SaveChangesAsync();

                // Re-fetch and update the DataGridView
                await LoadItem();
            }
        }
        public async Task DeleteItem()
        {
            // Delete the selected role from the database
            var selectedItem = dgv.CurrentRow?.DataBoundItem as FoodDrinks;

            if (selectedItem != null)
            {
                dbContext.FoodDrinks.Remove(selectedItem);
                await dbContext.SaveChangesAsync();
                await LoadItem(); // Reload items in the DataGridView
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region buttons events
        private void btnCancelSelection_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            txtFoodDrinkId.Text = "";
            txtFoodDrinkName.Text = "";
            txtPrice.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            pbFoodDrink.Image = null;
        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            await LoadItem();
            btnCancelSelection_Click(sender, e);
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddItem();
            btnCancelSelection_Click(sender, e);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateItem();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteItem();
            btnCancelSelection_Click(sender, e);
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "JPEG|*.jpg|All files|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Check if the selected file has a valid image extension
                string[] validExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();

                if (validExtensions.Contains(fileExtension))
                {
                    pbFoodDrink.Image = null;
                    pbFoodDrink.Image = Image.FromFile(openFileDialog.FileName);
                    //txtFilePath.Text = openFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("Invalid file format. Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        #endregion


    }
}
