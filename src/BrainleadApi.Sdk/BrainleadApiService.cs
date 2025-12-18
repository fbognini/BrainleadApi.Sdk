using BrainleadApi.Sdk.Carts;
using BrainleadApi.Sdk.Carts.AddCart;
using BrainleadApi.Sdk.Carts.DeleteCart;
using BrainleadApi.Sdk.Carts.UpdateCart;
using BrainleadApi.Sdk.Companies;
using BrainleadApi.Sdk.Companies.AddCompany;
using BrainleadApi.Sdk.Companies.UpdateCompany;
using BrainleadApi.Sdk.People;
using BrainleadApi.Sdk.People.AddPeople;
using BrainleadApi.Sdk.People.GetPeople;
using BrainleadApi.Sdk.People.UpdatePeople;
using fbognini.Sdk;
using fbognini.Sdk.Utils;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BrainleadApi.Sdk;

public interface IBrainleadApiService
{
    public static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    Task<AddCompanyResponse> AddCompany(AddCompanyRequest request, CancellationToken cancellationToken = default);
    Task<UpdateCompanyResponse> UpdateCompany(int brainleadId, AddCompanyRequest request, CancellationToken cancellationToken = default);
    
    Task<AddPeopleResponse> AddPeople(AddPeopleRequest request, CancellationToken cancellationToken = default);
    Task<UpdatePeopleResponse> UpdatePeople(int brainleadId, AddPeopleRequest request, CancellationToken cancellationToken = default);
    Task<List<Person>> GetPeople(GetPeopleRequest request, CancellationToken cancellationToken = default);
    Task<Person> GetPeopleById(int id, CancellationToken cancellationToken = default);

    Task<AddCartResponse> AddCart(CartRequest request, CancellationToken cancellationToken = default);
    Task<UpdateCartResponse> UpdateCart(int id, CartRequest request, CancellationToken cancellationToken = default);
    Task<DeleteCartResponse> DeleteCart(int id, CancellationToken cancellationToken = default);
}

internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public BrainleadApiSettings Settings { get; }
    public QueryStringBuilderFromJsonOptions? QueryStringBuilderFromJsonOptions { get; }


    public BrainLeadApiService(HttpClient client, IOptions<BrainleadApiSettings> options) 
            : base(client, options: IBrainleadApiService.JsonSerializerOptions)
    {
        Settings = options.Value;
        QueryStringBuilderFromJsonOptions = new QueryStringBuilderFromJsonOptions()
        {
            UseIndexForArrays = false,
            JsonSerializerOptions = IBrainleadApiService.JsonSerializerOptions
        };

        base.client.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Settings.ApiKey}:x")));
    }
}