using BrainleadApi.Sdk.Carts.DeleteCart;
using fbognini.Sdk;

namespace BrainleadApi.Sdk;


internal partial class BrainLeadApiService : BaseApiService, IBrainleadApiService
{

    public async Task<DeleteCartResponse> DeleteCart(int id, CancellationToken cancellationToken = default)
    {
        return await DeleteApiAsync<DeleteCartResponse>($"carts/{id}/delete", cancellationToken: cancellationToken);
    }
}