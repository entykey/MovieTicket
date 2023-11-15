namespace MovieTicket
{
    using MovieTicket.EFModels;
    using System.Linq;
    using System.Windows.Forms;
    using System;
    using System.Collections.Generic;


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
        }

        #region database methods
        public void BindDataMovieToDataGv()
        {
            var result = from c in dbContext.Movies.ToList()
                         //where c.HOTEN.Contains(txtKeyword.Text)
                         select c;
            //where c.MALOP == txtKeyword.Text
            // where entity.Name.Contains("xyz") = WHERE Name LIKE '%xyz%'
            dataGv.DataSource = result.ToList();
        }
        #endregion


        #region button events
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            BindDataMovieToDataGv();
        }
        #endregion

    }
}
