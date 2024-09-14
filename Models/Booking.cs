namespace TravelBookingModels.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public bool IsConfirmed { get; set; }

        // Foreign keys
        public int PackageId { get; set; }
        public TravelPackage TravelPackage { get; set; }

        public int UserId { get; set; }  // The customer who made the booking
        public User User { get; set; }
    }
}
