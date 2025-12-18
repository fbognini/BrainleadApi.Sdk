namespace BrainleadApi.Sdk.Carts
{
    public class CartRequest
    {
        public required string ShopUrl { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// 0 carrello
        /// 1 carrello abbandonato
        /// 2 ordine
        /// 3 ordine reso
        /// 4 ordine cancellato
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        ///  Mandatory only if [Status] > 1
        /// </summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>
        ///  Mandatory only if [Status] > 1
        /// </summary>
        public string? OrderNumber { get; set; }
        /// <summary>
        ///  Mandatory only if [Status] > 1
        /// </summary>
        public string? OrderStatus { get; set; }
        public string? OrderExternalId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = default!;
        public string CustomerSurname { get; set; } = default!;
        public string CustomerEmail { get; set; } = default!;
        public string CustomerExternalId { get; set; } = default!;
        public string? PaymentMethod { get; set; }

        public string? ShippingMethod { get; set; }
        public string? ShippingAddress { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingState { get; set; }
        public string? ShippingZipcode { get; set; }
        public string? ShippingRegion { get; set; }
        public string? ShippingCountry { get; set; }

        public required List<CartProduct> Products { get; set; }
        public required List<string> Coupons { get; set; }
        public string? TransactionId { get; set; }
        public double TotalTax { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalShipping { get; set; }
        /// <summary>
        /// Default 'EUR'
        /// </summary>
        public string? Currency { get; set; }
        public string? ExternalId { get; set; }

    }
}
