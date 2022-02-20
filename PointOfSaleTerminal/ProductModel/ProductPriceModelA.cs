namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelA
    {
        private decimal UnitPrice { get; set; } = 1.25m;
        private int Volume { get; set; } = 3;
        private decimal VolumePrice { get; set; } = 3.00m;

        public decimal CalculateProductAPrice(int productCounts)
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