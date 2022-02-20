namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelD
    {
        private decimal UnitPrice { get; set; } = 0.75m;

        public decimal CalculateProductDPrice(int productCounts)
        {
            return UnitPrice * productCounts;
        }
    }
}