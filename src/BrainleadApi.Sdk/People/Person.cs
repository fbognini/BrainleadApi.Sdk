namespace BrainleadApi.Sdk.People
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Surnmae { get; set; } = default!;
        public int CompanyId { get; set; }
        public string Email { get; set; } = default!;
        public string? ExternalId { get; set; }
    }
}
