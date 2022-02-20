using System.Collections.Generic;
using System.Linq;
using PointOfSaleTerminal.ProductModel;

namespace PointOfSaleTerminal
{
    public class PointOfSaleCalculator
    {
        private readonly IList<char> _productList;
        private readonly ProductPriceModelA _productPriceModelA;
        private readonly ProductPriceModelB _productPriceModelB;
        private readonly ProductPriceModelC _productPriceModelC;
        private readonly ProductPriceModelD _productPriceModelD;
        private decimal totalPrice;


        public PointOfSaleCalculator(
            string products,
            ProductPriceModelA productPriceModelA,
            ProductPriceModelB productPriceModelB,
            ProductPriceModelC productPriceModelC,
            ProductPriceModelD productPriceModelD
        )
        {
            _productList = products.ToUpper().ToCharArray().ToList();
            _productPriceModelA = productPriceModelA;
            _productPriceModelB = productPriceModelB;
            _productPriceModelC = productPriceModelC;
            _productPriceModelD = productPriceModelD;
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
                        totalPrice += _productPriceModelA.CalculateProductAPrice(product.productCount);
                        break;
                    case nameof(ProductCode.B):
                        totalPrice += _productPriceModelB.CalculateProductBPrice(product.productCount);
                        break;
                    case nameof(ProductCode.C):
                        totalPrice += _productPriceModelC.CalculateProductCPrice(product.productCount);
                        break;
                    case nameof(ProductCode.D):
                        totalPrice += _productPriceModelD.CalculateProductDPrice(product.productCount);
                        break;
                }
            }

            return totalPrice;
        }
    }
}