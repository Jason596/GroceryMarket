using PointOfSaleTerminal.ProductModel;
using Xunit;

namespace PointOfSaleTerminalTests
{
    public class ProductPriceModelBTests
    {
        [Theory]
        [InlineData(1, 0.0, 4.25)]
        [InlineData(2, 0.0, 8.5)]
        public void Test_Calculate_Product_B_Unit_Price_With_Default_Value(
            int productCounts,
            decimal unitPrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelB(unitPrice);

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductBPrice(productCounts));
        }

        [Theory]
        [InlineData(1, 5.0, 5.0)]
        [InlineData(2, 8.0, 16.0)]
        public void Test_Calculate_Product_B_Unit_Price_With_Different_Value(
            int productCounts,
            decimal unitPrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelB(unitPrice);

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductBPrice(productCounts));
        }
    }
}