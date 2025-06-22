using ECommerceSearchFuntion;
using System;
using System.Collections.Generic;

namespace ECommerceSearchFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product(1, "Namkeen", "Snacks"),
                new Product(2, "SmartWatch", "Electronics"),
                new Product(3, "Laptop", "Electronics"),
                new Product(4, "T-shirt", "Cloths"),
                new Product(5, "Headphones", "Electronics"),
                new Product(6, "EarPods F09", "Electronics"),
                new Product(7, "Biscuit", "Snacks"),
                new Product(8, "Soap", "Toiletries"),
                new Product(9, "Pen", "Stationary")
            };

            Console.WriteLine("Searching= Soap -> Linear Search:");
            var linearResult = SearchFunction.LinearSearch(products, "Soap");
            Console.WriteLine(linearResult != null ? linearResult.ToString() : "Not Found");

            Console.WriteLine("\nSearching= Soap -> Binary Search:");
            var binaryResult = SearchFunction.BinarySearch(products, "Soap");
            Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Not Found");
        }
    }
}
