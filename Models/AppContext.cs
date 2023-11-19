namespace MovieTicket.Models
{
    using MovieTicket.EFModels;
    using System;
    using System.Collections.Generic;

    public static class AppContext
    {
        public static Users CurrentUser { get; set; }
        public static List<string> Roles { get; set; }
    }
}
