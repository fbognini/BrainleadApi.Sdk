using BrainleadApi.Sdk.People;
using BrainleadApi.Sdk.People.AddPeople;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;

internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<AddPeopleResponse> AddPeople(AddPeopleRequest request, CancellationToken cancellationToken = default)
    {
        return await PostApiAsync<AddPeopleResponse, AddPeopleRequest>("people/add", request, cancellationToken: cancellationToken);
    }
}