using TravelBookingModels.Models;

namespace TravelBookingModels.ViewModels
{
    public class BookPackageViewModel
    {
        public TravelPackage TravelPackage { get; set; }
        public int SelectedPackageId { get; set; }

        public string CustomerName { get; set; } // If agency is booking on behalf of a customer
        public string CustomerEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; } // Price of the package
        public bool IsConfirmed { get; set; } // Confirmation flag
    }
}

//This view model is used when a customer or an agency books a travel package