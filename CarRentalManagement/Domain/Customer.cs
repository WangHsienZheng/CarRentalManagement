namespace CarRentalManagement.Domain
{
    public class Customer : BaseDomainModel
    {
        string? DrivingLicense {  get; set; }
        string? Address { get; set; }
        string? ContactNumber { get; set; }
        string? EmailAddress { get; set; }

    }
}
