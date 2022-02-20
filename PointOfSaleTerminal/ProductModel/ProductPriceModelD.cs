namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelD
    {
        private readonly decimal _unitPrice = 0.75m;

        public ProductPriceModelD(decimal unitPrice)
        {
            if (unitPrice != 0) _unitPrice = unitPrice;
        }


        /// <summary>
        /// Calculating the product D price
        /// </summary>
        /// <param name="productCounts"></param>
        /// <returns>
        ///  Total price of product D
        /// </returns>
        public decimal CalculateProductDPrice(int productCounts)
        {
            return _unitPrice * productCounts;
        }
    }
}