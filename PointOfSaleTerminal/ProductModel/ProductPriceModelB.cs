namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelB
    {
        private decimal UnitPrice { get; set; } = 4.25m;
        public decimal CalculateProductBPrice(int productCounts)
        {
            return UnitPrice * productCounts;
        }
    }
}