using BrainleadApi.Sdk.Companies;
using BrainleadApi.Sdk.Companies.AddCompany;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;


internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<AddCompanyResponse> AddCompany(AddCompanyRequest request, CancellationToken cancellationToken = default)
    {
        return await PostApiAsync<AddCompanyResponse, AddCompanyRequest>("companies/add", request, cancellationToken: cancellationToken);
    }
}