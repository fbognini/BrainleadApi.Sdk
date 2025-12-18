namespace BrainleadApi.Sdk.Companies
{
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Vat { get; set; }
        public string? FiscalCode { get; set; }
        public required string Email { get; set; }
        public string? ExternalId { get; set; }
    }
}
