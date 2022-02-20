using PointOfSaleTerminal.ProductModel;
using Xunit;

namespace PointOfSaleTerminalTests
{
    public class ProductPriceModelCTests
    {
        [Theory]
        [InlineData(1, 0.0, 0, 0.0, 1.0)]
        [InlineData(2, 0.0, 0, 0.0, 2.0)]
        [InlineData(3, 0.0, 0, 0.0, 3.0)]
        [InlineData(4, 0.0, 0, 0.0, 4.0)]
        public void Test_Calculate_Product_C_Unit_Price_With_Default_Value(
            int productCounts,
            decimal unitPrice,
            int volume,
            decimal volumePrice,
            decimal expectedValue
            )
        {
            // arrange

            // act
            var sut = new ProductPriceModelC(unitPrice, volume, volumePrice );

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductCPrice(productCounts));
        }

        [Theory]
        [InlineData(1, 1.0, 0, 0.0, 1.0)]
        [InlineData(2, 2.0, 0, 0.0, 4.0)]
        [InlineData(3, 3.0, 0, 0.0, 9.0)]
        [InlineData(4, 4.0, 0, 0.0, 16.0)]
        public void Test_Calculate_Product_A_Unit_Price_With_Different_Value(
            int productCounts,
            decimal unitPrice,
            int volume,
            decimal volumePrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelC(unitPrice, volume, volumePrice );

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductCPrice(productCounts));
        }

        [Theory]
        [InlineData(5, 0.0, 0, 3.0, 5.0)]
        [InlineData(6, 0.0, 0, 4.0, 4.0)]
        [InlineData(7, 0.0, 0, 5.0, 6.0)]
        [InlineData(8, 0.0, 0, 6.0, 8.0)]
        public void Test_Calculate_Product_A_Volume_Price_With_Default_Value(
            int productCounts,
            decimal unitPrice,
            int volume,
            decimal volumePrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelC(unitPrice, volume, volumePrice );

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductCPrice(productCounts));
        }


        [Theory]
        [InlineData(3, 1.0, 3, 4.0, 4.0)]
        [InlineData(4, 1.0, 3, 4.0, 5)]
        [InlineData(5, 1.0, 3, 4.0, 6)]
        public void Test_Calculate_Product_A_Volume_Price_With_Different_Value(
            int productCounts,
            decimal unitPrice,
            int volume,
            decimal volumePrice,
            decimal expectedValue
        )
        {
            // arrange

            // act
            var sut = new ProductPriceModelA(unitPrice, volume, volumePrice );

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductAPrice(productCounts));
        }
    }
}