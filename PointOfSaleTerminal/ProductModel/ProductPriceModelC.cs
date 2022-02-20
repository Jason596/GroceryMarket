namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelC
    {
        private readonly decimal _unitPrice = 1.00m;
        private readonly int _volume  = 6;
        private readonly decimal _VolumePrice = 5.00m;

        public ProductPriceModelC(decimal unitPrice, int volume, decimal volumePrice)
        {
            if (unitPrice != 0) _unitPrice = unitPrice;
            if (volume != 0) _volume = volume;
            if (volumePrice != 0)  _VolumePrice = volumePrice;
        }


        public decimal CalculateProductCPrice(int productCounts)
        {

            if (productCounts < _volume)
            {
                return _unitPrice * productCounts;
            }

            var divided = productCounts / _volume;
            var remainder = productCounts % _volume;

            if (remainder == 0)
            {
                return divided * _VolumePrice;
            }

            return divided * _VolumePrice + remainder * _unitPrice;
        }
    }
}