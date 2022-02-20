namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelD
    {
        private readonly decimal _unitPrice = 0.75m;

        public ProductPriceModelD(decimal unitPrice)
        {
            if (unitPrice !=0) _unitPrice = unitPrice;
        }


        public decimal CalculateProductDPrice(int productCounts)
        {
            return _unitPrice * productCounts;
        }
    }
}