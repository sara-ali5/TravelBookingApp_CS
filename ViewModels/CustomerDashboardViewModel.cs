using TravelBookingModels.Models;

namespace TravelBookingModels.ViewModels
{
    public class CustomerDashboardViewModel
    {

        public Customer Customer { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}

//Used to display customer information and booking history in the dashboard