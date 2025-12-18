using System.Text.Json.Serialization;

namespace BrainleadApi.Sdk.Carts.UpdateCart
{
    public class UpdateCartResponse
    {
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int? Id { get; set; }
        public bool Updated { get; set; }
    }
}
