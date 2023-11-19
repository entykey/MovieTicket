namespace MovieTicket
{
    using MovieTicket.EFModels;
    using System.Linq;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public partial class ucMovies : UserControl
    {
        private static ucMovies _instance;

        public static ucMovies Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMovies();
                return _instance;
            }
        }

        #region EntityFramework entity
        CRVCinemaEntities dbContext = new CRVCinemaEntities();
        #endregion

        public ucMovies()
        {
            InitializeComponent();
            this.btnDeleteMovie.Enabled= false;
            this.btnUpdateMovie.Enabled= false;
            this.btnCancelSelection.Enabled= false;
        }

        #region database methods
        public void BindDataMovieToDataGv()
        {
            var result = from m in dbContext.Movies.ToList()
                         select m;
            //where c.MALOP == txtKeyword.Text
            // where entity.Name.Contains("xyz") = WHERE Name LIKE '%xyz%'
            dataGv.DataSource = result.ToList();
        }
        public async Task AddMovie()
        {
            decimal price = txtPrice.Text == "" ? 30000 : decimal.Parse(txtPrice.Text);
            dbContext.Movies.Add(new Movies() { MovieId = Guid.NewGuid().ToString(), Title = txtTitle.Text, Director = txtDirector.Text, ReleaseDate = dtpReleaseDate.Value, Description = txtDescription.Text, SeatPrice = price });
            await Task.FromResult(dbContext.SaveChanges());
            BindDataMovieToDataGv();
        }
        public async Task UpdateMovie()
        {
            // Find the movie in the database
            Movies movieToUpdate = dbContext.Movies.Find(txtMovieId.Text);

            if (movieToUpdate != null)
            {
                // Update the movie properties
                movieToUpdate.Title = txtTitle.Text;
                movieToUpdate.Director = txtDirector.Text;
                movieToUpdate.ReleaseDate = dtpReleaseDate.Value;
                movieToUpdate.Description = txtDescription.Text;
                movieToUpdate.SeatPrice = decimal.Parse(txtPrice.Text);

                // Save the changes to the database
                await Task.FromResult(dbContext.SaveChanges());

                // Re-fetch and update the DataGridView
                BindDataMovieToDataGv();
            }
        }
        public async Task DeleteMovie()
        {
            Movies m = dbContext.Movies.Where(p => p.MovieId == txtMovieId.Text).SingleOrDefault();
            dbContext.Movies.Remove(m);
            await Task.FromResult(dbContext.SaveChanges());
            BindDataMovieToDataGv();
        }
        #endregion

        #region form events
        private void dataGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 13)  // ignore header row and any column
                return;

            txtMovieId.Text = dataGv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dataGv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDirector.Text = dataGv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dataGv.Rows[e.RowIndex].Cells[4].Value.ToString();

            // Check if the SeatPrice cell value is null before assigning
            if (dataGv.Rows[e.RowIndex].Cells[5].Value != null)
            {
                txtPrice.Text = dataGv.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else
            {
                // show 30000 as default
                txtPrice.Text = 30000.ToString();
            }

            var startTime = (from m in dbContext.Movies
                             join s in dbContext.Shows on m.MovieId equals s.MovieId
                             where m.MovieId == txtMovieId.Text
                             select s.StartTime).ToList();

            cbShow.DataSource = startTime;

            // Check if the cell value is null before converting to DateTime
            if (dataGv.Rows[e.RowIndex].Cells[3].Value != null)
            {
                dtpReleaseDate.Value = Convert.ToDateTime(dataGv.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else
            {
                // Use DateTime.Now as a default value if the cell value is null
                dtpReleaseDate.Value = DateTime.Now;
            }
            this.btnAddMovie.Enabled = false;
            //this.btnUpdate.Enabled = true;
            this.btnDeleteMovie.Enabled = true;
            this.btnUpdateMovie.Enabled = true;
            this.btnCancelSelection.Enabled = true;
        }
        #endregion


        #region button events
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            BindDataMovieToDataGv();
        }
        private async void btnAddMovie_Click(object sender, EventArgs e)
        {
            await AddMovie();
            btnCancelSelection_Click(sender, e);
        }
        private async void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            await UpdateMovie();
        }
        private async void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            await DeleteMovie();
            btnCancelSelection_Click(sender, e);
        }
        private void btnCancelSelection_Click(object sender, EventArgs e)
        {
            btnAddMovie.Enabled = true;
            txtMovieId.Text = "";
            txtTitle.Text = "";
            txtDirector.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cbShow.SelectedIndex = -1;
            cbShow.DataSource = null;
            dtpReleaseDate.Value = DateTime.Now;
            btnUpdateMovie.Enabled = false;
            btnDeleteMovie.Enabled = false;
        }

        #endregion

        private void ucMovies_Load(object sender, EventArgs e)
        {

        }

        private void dataGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
