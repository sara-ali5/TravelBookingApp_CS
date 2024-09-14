using TravelBookingModels.Models;

namespace TravelBookingModels.ViewModels
{
    public class TravelPackageDetailsViewModel
    {
        public TravelPackage TravelPackage { get; set; }
        public Agency ManagingAgency { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}

//This is used to display travel package details when a user views a specific travel package.