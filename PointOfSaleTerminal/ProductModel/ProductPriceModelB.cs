namespace PointOfSaleTerminal.ProductModel
{
    public class ProductPriceModelB
    {
        private readonly decimal _unitPrice = 4.25m;

        public ProductPriceModelB(decimal unitPrice)
        {
            if (unitPrice != 0) _unitPrice = unitPrice;
        }


        /// <summary>
        /// Calculating the product B price
        /// </summary>
        /// <param name="productCounts"></param>
        /// <returns>
        ///  Total price of product B
        /// </returns>
        public decimal CalculateProductBPrice(int productCounts)
        {
            return _unitPrice * productCounts;
        }
    }
}