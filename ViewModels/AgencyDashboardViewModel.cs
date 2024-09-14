using TravelBookingModels.Models;

namespace TravelBookingModels.ViewModels
{
    public class AgencyDashboardViewModel
    {
        public Agency Agency { get; set; }
        public List<TravelPackage> ManagedPackages { get; set; }
        public List<Booking> AllBookings { get; set; } // All bookings for packages managed by the agency
    }
}//Used to display agency-related data on the agency dashboard