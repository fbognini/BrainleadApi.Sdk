using BrainleadApi.Sdk.Carts;
using BrainleadApi.Sdk.Carts.AddCart;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;


internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<AddCartResponse> AddCart(CartRequest request, CancellationToken cancellationToken = default)
    {
        return await PostApiAsync<AddCartResponse, CartRequest>("carts/add", request, cancellationToken: cancellationToken);
    }
}