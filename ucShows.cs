namespace MovieTicket
{
    using MovieTicket.EFModels;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;


    public partial class ucShows : UserControl
    {
        private static ucShows _instance;

        public static ucShows Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucShows();
                return _instance;
            }
        }

        #region EntityFramework entity
        CRVCinemaEntities dbContext = new CRVCinemaEntities();
        #endregion

        public ucShows()
        {
            InitializeComponent();

            // format DateTimePicker to pick both Date & Time
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            this.btnDeleteShow.Enabled = false;
            this.btnUpdateShow.Enabled = false;
            this.btnCancelSelection.Enabled = false;

            LoadMovieNames();
        }

        #region database operations
        private async Task LoadMovieNames()
        {
            // Fetch movie names and IDs from the database
            var movieData = await dbContext.Movies
                .Select(m => new { m.MovieId, m.Title })
                .ToListAsync();

            // Populate ComboBox with movie names
            cboMovieName.DataSource = movieData;
            cboMovieName.DisplayMember = "Title";
            cboMovieName.ValueMember = "MovieId";
        }
        public async Task BindDataShowsToDataGv()
        {
            var result = await dbContext.Shows
                .Include(s => s.Movies) // Include the Movie navigation property
                .ToListAsync();

            // Create a new anonymous type to represent the data you want to display
            var showsData = result.Select(s => new
            {
                s.ShowId,
                s.MovieId,
                MovieName = s.Movies.Title, // Access the Title property of the related Movie
                s.StartTime,
                s.EndTime,
                //s.SeatPrice
                // Add other properties as needed
            });

            dataGv.DataSource = showsData.ToList();
        }
        public async Task BindDataShowsToDataGvByMovieId(string movieId)
        {
            var result = await dbContext.Shows
                .Include(s => s.Movies) // Include the Movie navigation property
                .Where(s => s.MovieId == movieId)
                .ToListAsync();

            // Create a new anonymous type to represent the data you want to display
            var showsData = result.Select(s => new
            {
                s.ShowId,
                s.MovieId,
                MovieName = s.Movies.Title, // Access the Title property of the related Movie
                s.StartTime,
                s.EndTime,
                //s.SeatPrice
                // Add other properties as needed
            });

            dataGv.DataSource = showsData.ToList();
        }
        public async Task AddShow()
        {
            dbContext.Shows.Add(new Shows() { ShowId = Guid.NewGuid().ToString(), MovieId = txtMovieId.Text, StartTime = dtpStartTime.Value, EndTime = dtpEndTime.Value });
            await Task.FromResult(dbContext.SaveChanges());
            await BindDataShowsToDataGv();
        }
        public async Task UpdateShow()
        {
            // Find the movie in the database
            Shows showToUpdate = dbContext.Shows.Find(txtShowId.Text);

            if (showToUpdate != null)
            {
                // Update the movie properties
                showToUpdate.ShowId = txtMovieId.Text;
                showToUpdate.StartTime = dtpStartTime.Value;
                showToUpdate.EndTime = dtpEndTime.Value;

                // Save the changes to the database
                await Task.FromResult(dbContext.SaveChanges());

                // Re-fetch and update the DataGridView
                await BindDataShowsToDataGv();
            }
        }
        public async Task DeleteShow()
        {
            Shows s = dbContext.Shows.Where(p => p.ShowId == txtShowId.Text).SingleOrDefault();
            dbContext.Shows.Remove(s);
            await Task.FromResult(dbContext.SaveChanges());
            await BindDataShowsToDataGv();
        }
        #endregion



        #region form events
        private async void cboMovieName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected movie data
            var selectedMovie = (dynamic)cboMovieName.SelectedItem;

            // Display the MovieId in the txtMovieId TextBox
            if (selectedMovie != null)
            {
                txtMovieId.Text = selectedMovie.MovieId;
                txtMovieTitle.Text = selectedMovie.Title;

                // Fetch shows based on the selected movie's MovieId
                await BindDataShowsToDataGvByMovieId(txtMovieId.Text);
            }
        }
        private void dataGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 13)  // ignore header row and any column
                return;

            txtShowId.Text = dataGv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMovieId.Text = dataGv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMovieTitle.Text = dataGv.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Check if the cell value is null before converting to DateTime
            if (dataGv.Rows[e.RowIndex].Cells[3].Value != null)
            {
                dtpStartTime.Value = Convert.ToDateTime(dataGv.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else
            {
                // Use DateTime.Now as a default value if the cell value is null
                dtpStartTime.Value = DateTime.Now;
            }
            if (dataGv.Rows[e.RowIndex].Cells[4].Value != null)
            {
                dtpEndTime.Value = Convert.ToDateTime(dataGv.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            else
            {
                // Use DateTime.Now as a default value if the cell value is null
                dtpEndTime.Value = DateTime.Now;
            }

            this.btnAddShow.Enabled = false;
            //this.btnUpdate.Enabled = true;
            this.btnDeleteShow.Enabled = true;
            this.btnUpdateShow.Enabled = true;
            this.btnCancelSelection.Enabled = true;
        }
        #endregion

        #region button events
        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            await BindDataShowsToDataGv();
        }
        private async void btnAddShow_Click(object sender, EventArgs e)
        {
            await AddShow();
        }
        private async void btnUpdateShow_Click(object sender, EventArgs e)
        {
            await UpdateShow();
        }
        private async void btnDeleteShow_Click(object sender, EventArgs e)
        {
            await DeleteShow();
        }
        #endregion

        private void btnCancelSelection_Click(object sender, EventArgs e)
        {
            btnAddShow.Enabled = true;
            txtMovieId.Text = "";
            txtShowId.Text = "";
            txtMovieTitle.Text = "";
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
            btnUpdateShow.Enabled = false;
            btnDeleteShow.Enabled = false;
        }

        private void ucShows_Load(object sender, EventArgs e)
        {

        }
    }
}
