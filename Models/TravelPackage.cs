using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TravelBookingModels.Models
{
    public class TravelPackage
    {
        [Key]
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public string DestinationCity { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AvailableSlots { get; set; }


        // Foreign key for the managing agency
        public int? AgencyId { get; set; }
        public Agency ManagingAgency { get; set; }

        // Relationship
        public ICollection<Booking> Bookings { get; set; }
    }
}
