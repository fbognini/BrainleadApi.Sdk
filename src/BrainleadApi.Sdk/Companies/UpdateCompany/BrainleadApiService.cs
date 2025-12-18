using BrainleadApi.Sdk.Companies;
using BrainleadApi.Sdk.Companies.UpdateCompany;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;


internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<UpdateCompanyResponse> UpdateCompany(int brainleadId, AddCompanyRequest request, CancellationToken cancellationToken = default)
    {
        return await PostApiAsync<UpdateCompanyResponse, AddCompanyRequest>($"companies/{brainleadId}/update", request, cancellationToken: cancellationToken);
    }
}