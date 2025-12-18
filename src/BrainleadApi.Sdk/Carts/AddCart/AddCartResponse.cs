using System.Text.Json.Serialization;

namespace BrainleadApi.Sdk.Carts.AddCart
{
    public class AddCartResponse
    {
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int? Id { get; set; }
    }
}
