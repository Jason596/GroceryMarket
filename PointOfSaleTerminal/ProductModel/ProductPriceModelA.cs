namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelA
    {
        private readonly decimal _unitPrice = 1.25m;
        private readonly int _volume = 3;
        private readonly decimal _volumePrice = 3.00m;


        public ProductPriceModelA(decimal unitPrice, int volume, decimal volumePrice)
        {
            if (unitPrice != 0) _unitPrice = unitPrice;
            if (volume != 0) _volume = volume;
            if (volume != 0 ) _volumePrice = volumePrice;

        }

        public decimal CalculateProductAPrice(int productCounts)
        {
            if (productCounts < _volume)
            {
                return _unitPrice * productCounts;
            }

            var divided = productCounts / _volume;
            var remainder = productCounts % _volume;

            if (remainder == 0)
            {
                return divided * _volumePrice;
            }

            return divided * _volumePrice + remainder * _volumePrice;
        }
    }
}