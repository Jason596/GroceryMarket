using System;
using System.Linq;
using System.Text.RegularExpressions;
using PointOfSaleTerminal;
using PointOfSaleTerminal.ProductModel;

namespace GroceryMarket
{
    public class Solution
    {
        private const string RgxString = "[e-zE-Z]";

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting the Grocery Market Program...");
                var (productAUnitPrice, productAVolume, productAVolumePrice) = SetPriceForProductA();
                var productBUnitPrice = SetPriceForProductB();
                var (productCUnitPrice, productCVolume, productCVolumePrice) = SetPriceForProductC();
                var productDUnitPrice = SetPriceForProductD();

                while (true)
                {
                    if (ScanningProducts(out var products)) continue;

                    var terminal = new PointOfSaleCalculator(
                        products,
                        new ProductPriceModelA(productAUnitPrice, productAVolume, productAVolumePrice),
                        new ProductPriceModelB(productBUnitPrice),
                        new ProductPriceModelC(productCUnitPrice, productCVolume, productCVolumePrice),
                        new ProductPriceModelD(productDUnitPrice)
                        );

                    var totalPrice = terminal.CalculateTotal();

                    Console.WriteLine($"The total grocery price is ${totalPrice}");
                    Console.WriteLine();

                    Console.WriteLine("Continue check out, please enter yes/no.");
                    var stop = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(stop) && stop.ToLower() == "yes")
                    {
                        Console.WriteLine();
                        continue;
                    }

                    break;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine();
                Console.WriteLine("Exit the program...");
            }
        }


        private static bool ScanningProducts(out string products)
        {
            Console.WriteLine("\nPlease scan the product...");
            var rgx = new Regex(RgxString);
            products = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(products) || products.Any(char.IsDigit) || rgx.IsMatch(products))
            {
                Console.WriteLine("Fail to scan the product, please try again.");
                return true;
            }

            Console.WriteLine();
            Console.WriteLine($"The products we have scanned are {products}");
            return false;
        }

        private static (decimal, int, decimal) SetPriceForProductA()
        {
            Console.WriteLine("\nPlease enter the unit price for product A for today.");

            if (!decimal.TryParse(Console.ReadLine() ?? "0.0m", out var productAUnitPrice ))
            {
                Console.WriteLine("Please enter correct number unit price for product A.");
                throw new Exception("Error - Something is wrong, stop processing.");
            }

            Console.WriteLine("\nPlease enter the volume price for product A (enter as \"volume price\" format).");
            var productAArray = Console.ReadLine()?.Split(" ");
            var productAVolumeString = productAArray?.ElementAt(0) ?? "0";
            var productAVolumePriceString = productAArray?.ElementAt(1) ?? "0.0m";

            if (!int.TryParse(productAVolumeString, out var productAVolume))
            {
                Console.WriteLine("Please enter correct number for the product A volume.");
                throw new Exception("Error - Something is wrong, stop processing.");
            }

            if (!decimal.TryParse(productAVolumePriceString, out var productAVolumePrice))
            {
                Console.WriteLine("Error - Please enter correct number for the product A volume price.");
                throw new Exception("Something is wrong, stop processing.");
            }

            return (productAUnitPrice, productAVolume, productAVolumePrice);
        }

        private static decimal SetPriceForProductB()
        {
            Console.WriteLine("\nPlease enter the unit price for product B for today.");

            if (!decimal.TryParse(Console.ReadLine() ?? "0.0m", out var productBUnitPrice))
            {
                Console.WriteLine("Please enter correct number unit price for product B.");
                throw new Exception("Error - Something is wrong, stop processing.");
            }

            return productBUnitPrice;
        }

        private static (decimal, int, decimal) SetPriceForProductC()
        {
            Console.WriteLine("\nPlease enter the unit price for product C for today.");

            if (!decimal.TryParse(Console.ReadLine() ?? "0.0m", out var productCUnitPrice))
            {
                Console.WriteLine("\nPlease enter correct number unit price for product C.");
                throw new Exception("Error - Something is wrong, stop processing.");
            }

            Console.WriteLine("\nPlease enter the volume price for product C (enter as \"volume price\" format).");
            var productCArray = Console.ReadLine()?.Split(" ");
            var productCVolumeString = productCArray?.ElementAt(0) ?? "0";
            var productCVolumePriceString = productCArray?.ElementAt(1) ?? "0.0m";

            if (!int.TryParse(productCVolumeString, out var productCVolume))
            {
                Console.WriteLine("Please enter correct number for the product C volume.");
                throw new Exception("Error - Something is wrong, stop processing.");
            }

            if (!decimal.TryParse(productCVolumePriceString, out var productCVolumePrice))
            {
                Console.WriteLine("Error - Please enter correct number for the product C volume price.");
                throw new Exception("Something is wrong, stop processing.");
            }

            return (productCUnitPrice, productCVolume, productCVolumePrice);
        }

        private static decimal SetPriceForProductD()
        {
            Console.WriteLine("\nPlease enter the unit price for product D for today.");

            if (!decimal.TryParse(Console.ReadLine() ?? "0.0m", out var productDUnitPrice))
            {
                Console.WriteLine("Please enter correct number unit price for product D.");
                throw new Exception("Error - Something is wrong, stop processing.");
            }

            return productDUnitPrice;
        }
    }
}