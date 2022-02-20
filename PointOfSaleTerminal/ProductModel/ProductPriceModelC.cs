namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelC
    {
        private decimal UnitPrice { get; set; } = 1.00m;
        private int Volume { get; set; } = 6;
        private decimal VolumePrice { get; set; } = 5.00m;

        public decimal CalculateProductCPrice(int productCounts)
        {

            if (productCounts < Volume)
            {
                return UnitPrice * productCounts;
            }

            var divided = productCounts / Volume;
            var remainder = productCounts % Volume;

            if (remainder == 0)
            {
                return divided * VolumePrice;
            }

            return divided * VolumePrice + remainder * UnitPrice;
        }
    }
}