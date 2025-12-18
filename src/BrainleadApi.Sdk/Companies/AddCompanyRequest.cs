using System.Text.Json.Serialization;

namespace BrainleadApi.Sdk.Companies;

public class AddCompanyRequest
{
    public required string Name { get; set; }
    public string? Vat { get; set; }
    public string? FiscalCode { get; set; }
    public required string Email { get; set; }
    public string? ExternalId { get; set; }

    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalParameters { get; set; }
}
