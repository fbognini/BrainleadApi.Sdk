using BrainleadApi.Sdk.Carts;
using BrainleadApi.Sdk.Carts.UpdateCart;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;


internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{
    public async Task<UpdateCartResponse> UpdateCart(int id, CartRequest request, CancellationToken cancellationToken = default)
    {
        return await PostApiAsync<UpdateCartResponse, CartRequest>($"carts/{id}/update", request, cancellationToken: cancellationToken);
    }
}