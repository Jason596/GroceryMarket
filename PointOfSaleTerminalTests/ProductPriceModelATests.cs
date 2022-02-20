using PointOfSaleTerminal.ProductModel;
using Xunit;

namespace PointOfSaleTerminalTests
{
    public class ProductPriceModelATests
    {
        [Theory]
        [InlineData(1, 0.0, 0, 0.0, 1.25)]
        [InlineData(2, 0.0, 0, 0.0, 2.5)]
        public void Test_Calculate_Product_A_Unit_Price_With_Default_Value(
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

        [Theory]
        [InlineData(1, 10.0, 0, 0.0, 10.0)]
        [InlineData(2, 20.0, 0, 0.0, 40.0)]
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
            var sut = new ProductPriceModelA(unitPrice, volume, volumePrice );

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductAPrice(productCounts));
        }

        [Theory]
        [InlineData(3, 0.0, 0, 0.0, 3.0)]
        [InlineData(4, 0.0, 0, 0.0, 4.25)]
        [InlineData(5, 0.0, 0, 0.0, 5.5)]
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
            var sut = new ProductPriceModelA(unitPrice, volume, volumePrice );

            // assert
            Assert.Equal(expectedValue,sut.CalculateProductAPrice(productCounts));
        }


        [Theory]
        [InlineData(3, 1.0, 3, 4.0, 4.0)]
        [InlineData(4, 1.0, 3, 4.0, 5.0)]
        [InlineData(5, 1.0, 3, 4.0, 6.0)]
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