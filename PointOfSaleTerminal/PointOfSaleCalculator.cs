using System.Collections.Generic;
using System.Linq;
using PointOfSaleTerminal.ProductModel;

namespace PointOfSaleTerminal
{
    public class PointOfSaleCalculator
    {
        private readonly IList<char> _productList;
        private decimal totalPrice;


        public PointOfSaleCalculator(string products)
        {
            _productList = products.ToCharArray().ToList();
        }


        public decimal CalculateTotal()
        {
            // calculate the counts
            var groupedProduct = _productList
                .GroupBy(item => item)
                .Select(item => new
                {
                    productCode = item.Key.ToString(),
                    productCounts = item.Count()
                })
                .ToList();

            // shouldn't have item has zero count
            foreach (var product in groupedProduct)
            {
                switch (product.productCode)
                {
                    case nameof(ProductCode.A):
                        totalPrice += CalculateProductAPrice(product.productCounts);
                        break;
                    case nameof(ProductCode.B):
                        totalPrice += CalculateProductBPrice(product.productCounts);
                        break;
                    case nameof(ProductCode.C):
                        totalPrice += CalculateProductCPrice(product.productCounts);
                        break;
                    case nameof(ProductCode.D):
                        totalPrice += CalculateProductDPrice(product.productCounts);
                        break;
                }
            }

            return totalPrice;
        }


        private decimal CalculateProductDPrice(int productCounts)
        {
            return new ProductPriceModelD().UnitPrice * productCounts;
        }

        private decimal CalculateProductCPrice(int productCounts)
        {
            var productPriceModelC = new ProductPriceModelC();

            if (productCounts < productPriceModelC.Volume)
            {
                return productPriceModelC.UnitPrice * productCounts;
            }

            var divided = productCounts / productPriceModelC.Volume;
            var remainder = productCounts % productPriceModelC.Volume;

            if (remainder == 0)
            {
                return divided * productPriceModelC.VolumePrice;
            }

            return divided * productPriceModelC.VolumePrice + remainder * productPriceModelC.UnitPrice;
        }

        private decimal CalculateProductBPrice(int productCounts)
        {
            return new ProductPriceModelB().UnitPrice * productCounts;
        }

        private decimal CalculateProductAPrice(int productCounts)
        {
            var productPriceModelA = new ProductPriceModelA();

            if (productCounts < productPriceModelA.Volume)
            {
                return productPriceModelA.UnitPrice * productCounts;
            }

            var divided = productCounts / productPriceModelA.Volume;
            var remainder = productCounts % productPriceModelA.Volume;

            if (remainder == 0)
            {
                return divided * productPriceModelA.VolumePrice;
            }

            return divided * productPriceModelA.VolumePrice + remainder * productPriceModelA.UnitPrice;
        }
    }
}