namespace TravelBookingModels.Models
{
    public class Customer : User
    {
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
    }
}
