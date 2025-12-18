using BrainleadApi.Sdk.People;
using BrainleadApi.Sdk.People.GetPeople;
using fbognini.Sdk;
using fbognini.Sdk.Utils;

namespace BrainleadApi.Sdk;

internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<List<Person>> GetPeople(GetPeopleRequest request, CancellationToken cancellationToken = default)
    {
        return await GetApiAsync<List<Person>>(request.ToQueryString("people/", QueryStringBuilderFromJsonOptions), cancellationToken: cancellationToken);
    }
}