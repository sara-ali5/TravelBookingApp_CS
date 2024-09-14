using System.ComponentModel.DataAnnotations;

namespace TravelBookingModels.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Customer" or "Agency"


        public string AgencyName { get; set; } //for Agencies

        public ICollection<Booking> Bookings { get; set; } // Bookings made by the user (either customer or agency for their customers)

    }
}
