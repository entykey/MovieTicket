namespace MovieTicket.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;

    public class User : IdentityUser
    {
        // additional properties will go here

        // https://www.entityframeworktutorial.net/efcore/one-to-many-conventions-entity-framework-core.aspx

        [Column(TypeName = "nvarchar(150)")]
        [MaxLength(100)]
        public string FullName { get; set; }    // not null
        public DateTimeOffset? DateJoined { get; set; } = GetCurrentTimeInDesiredTimeZone();  // DateTime.Now;
        public string? Country { set; get; }    // nullable ("?" postfix) or no row can be inserted !!!
        [MaxLength(100)]
        public string? City { set; get; }
        [MaxLength(255)]
        public string? Address { set; get; }
        [DataType(DataType.Date)]
        public DateTime? Birthday { set; get; }
        [MaxLength(100)]
        public string? TimeZone { set; get; }
        [MaxLength(100)]
        public string? Gender { set; get; }
        [MaxLength(100)]
        public string? University { set; get; }
        [MaxLength(260)]
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }



        private static DateTime GetCurrentTimeInDesiredTimeZone()
        {
            TimeZoneInfo desiredTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // ((GMT+07:00) Bangkok, Hanoi, Jakarta)

            return TimeZoneInfo.ConvertTime(DateTime.Now, desiredTimeZone);
        }
    }
}
