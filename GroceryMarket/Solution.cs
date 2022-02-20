using System;
using PointOfSaleTerminal;

namespace GroceryMarket
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Starting the Grocery Market Program...");
                Console.WriteLine("Please scan the product...");

                var products = Console.ReadLine();
                if (products == null)
                {
                    Console.WriteLine("Fail to scan the product, please try again.");
                    continue;
                }

                Console.WriteLine($"The product we have scanned are {products}");
                var terminal = new PointOfSaleCalculator(products.ToUpper());

                var totalPrice = terminal.CalculateTotal();
                Console.WriteLine($"The total grocery price is {totalPrice}");
                Console.WriteLine();

                Console.WriteLine("Continue check out, type YES/NO ");
                var stop = Console.ReadLine();
                if (stop != null && stop.ToLower() == "yes") continue;

                break;
            }
        }
    }
}