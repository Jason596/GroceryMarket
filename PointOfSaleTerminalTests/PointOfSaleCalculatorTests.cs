using System.Collections.Generic;
using PointOfSaleTerminal;
using PointOfSaleTerminal.ProductModel;
using Xunit;

namespace PointOfSaleTerminalTests
{
    public class PointOfSaleCalculatorTests
    {

        [Theory]
        [InlineData("ccccccc", 0.0, 0, 0.0, 0.0, 0.0, 0, 0.0, 0.0, 6.0)]
        [InlineData("ABCDABA", 0.0, 0, 0.0, 0.0, 0.0, 0, 0.0, 0.0, 13.25)]
        [InlineData("ABCD", 0.0, 0, 0.0, 0.0, 0.0, 0, 0.0, 0.0, 7.25)]
        public void Test_Point_Of_Sales_Calculator(
            string products,
            decimal productAUnitPrice,
            int productAVolume,
            decimal productAVolumePrice,
            decimal productBUnitPrice,
            decimal productCUnitPrice,
            int productCVolume,
            decimal productCVolumePrice,
            decimal productDUnitPrice,
            decimal expectedValue
            )
        {
            // arrange

            // act
            var sut = new PointOfSaleCalculator(
                products,
                new ProductPriceModelA(productAUnitPrice, productAVolume, productAVolumePrice),
                new ProductPriceModelB(productBUnitPrice),
                new ProductPriceModelC(productCUnitPrice, productCVolume, productCVolumePrice),
                new ProductPriceModelD(productDUnitPrice)
                );

            // assert

            Assert.Equal(expectedValue, sut.CalculateTotal());
        }
    }
}