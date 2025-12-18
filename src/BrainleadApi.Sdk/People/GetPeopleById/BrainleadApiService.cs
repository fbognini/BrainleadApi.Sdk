using BrainleadApi.Sdk.People;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;

internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{

    public async Task<Person> GetPeopleById(int id, CancellationToken cancellationToken = default)
    {
        return await GetApiAsync<Person>($"people/{id}", cancellationToken: cancellationToken);
    }
}