using System;
using System.Linq;
using System.Text.RegularExpressions;
using PointOfSaleTerminal;

namespace GroceryMarket
{
    public class Solution
    {
        private const string RgxString = "[e-zE-Z]";

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Starting the Grocery Market Program...");
                Console.WriteLine("Please scan the product...");

                var rgx = new Regex(RgxString);
                var products = Console.ReadLine().ToUpper();
                if (string.IsNullOrWhiteSpace(products) || products.Any(char.IsDigit) || rgx.IsMatch(products))
                {
                    Console.WriteLine("Fail to scan the product, please try again.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine($"The products we have scanned are {products}");

                var terminal = new PointOfSaleCalculator(products);
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
    }
}