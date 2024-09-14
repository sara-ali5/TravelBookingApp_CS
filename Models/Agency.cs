namespace TravelBookingModels.Models
{
    public class Agency :User
    {
        public string ContactPerson { get; set; }
        public ICollection<TravelPackage> ManagedPackages { get; set; } // Packages the agency manages
    }
}
