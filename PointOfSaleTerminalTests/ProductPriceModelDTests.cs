using PointOfSaleTerminal.ProductModel;
using Xunit;

namespace PointOfSaleTerminalTests
{
    public class ProductPriceModelDTests
    {
        [Theory]
        [InlineData(1, 0.0, 0.75)]
        [InlineData(2, 0.0, 1.5)]
        public void Test_Calculate_Product_D_Unit_Price_With_Default_Value(
            int productCounts,
            decimal unitPrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelD(unitPrice);

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductDPrice(productCounts));
        }

        [Theory]
        [InlineData(1, 3.5, 3.5)]
        [InlineData(2, 8.5, 17.0)]
        public void Test_Calculate_Product_D_Unit_Price_With_Different_Value(
            int productCounts,
            decimal unitPrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelD(unitPrice);

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductDPrice(productCounts));
        }
    }
}