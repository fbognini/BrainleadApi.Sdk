namespace BrainleadApi.Sdk.Carts
{
    public class CartProduct
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string Img { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? Url { get; set; }
        public string? ExternalId { get; set; }
        public int Qta { get; set; }
        public double Total { get; set; }
    }
}
