namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelB
    {
        private readonly decimal _unitPrice = 4.25m;


        public ProductPriceModelB(decimal unitPrice)
        {
            if (unitPrice != 0) _unitPrice = unitPrice;
        }


        public decimal CalculateProductBPrice(int productCounts)
        {
            return _unitPrice * productCounts;
        }
    }
}