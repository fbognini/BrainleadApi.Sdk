using System.Text.Json.Serialization;

namespace BrainleadApi.Sdk.People
{
    public class AddPeopleRequest
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public int CompanyId { get; set; }
        public required string Email { get; set; }
        public string? ExternalId { get; set; }


        [JsonExtensionData]
        public IDictionary<string, object>? AdditionalParameters { get; set; }
    }
}
