namespace MovieTicket
{
    using System;



    public static class Globals
    {
        public static string ConnectionString { get; set; }

        // Add other global variables as needed

        static Globals()
        {
            // Initialize default values
            ConnectionString = "Server=.; Database=CRVCinema; Trusted_Connection=True; MultipleActiveResultSets=True; TrustServerCertificate=True";
        }
    }

}
