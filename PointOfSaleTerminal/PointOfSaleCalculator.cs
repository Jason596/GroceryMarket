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
            // calculate product count for each product
            var groupedProducts = _productList
                .GroupBy(item => item)
                .Select(item => new
                {
                    productCode = item.Key.ToString(),
                    productCount = item.Count()
                })
                .ToList();

            foreach (var product in groupedProducts)
            {
                switch (product.productCode)
                {
                    case nameof(ProductCode.A):
                        totalPrice += new ProductPriceModelA().CalculateProductAPrice(product.productCount);
                        break;
                    case nameof(ProductCode.B):
                        totalPrice += new ProductPriceModelB().CalculateProductBPrice(product.productCount);
                        break;
                    case nameof(ProductCode.C):
                        totalPrice += new ProductPriceModelC().CalculateProductCPrice(product.productCount);
                        break;
                    case nameof(ProductCode.D):
                        totalPrice += new ProductPriceModelD().CalculateProductDPrice(product.productCount);
                        break;
                }
            }
            return totalPrice;
        }
    }
}