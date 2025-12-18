using BrainleadApi.Sdk.People;
using BrainleadApi.Sdk.People.UpdatePeople;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;

internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<UpdatePeopleResponse> UpdatePeople(int brainleadId, AddPeopleRequest request, CancellationToken cancellationToken = default)
    {
        return await PostApiAsync<UpdatePeopleResponse, AddPeopleRequest>($"people/{brainleadId}/update", request, cancellationToken: cancellationToken);
    }
}