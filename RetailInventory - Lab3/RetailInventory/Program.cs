using System;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new retailDb())
            {
       
                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    var electronics = new Category { Name = "Electronics" };
                    context.Categories.Add(electronics);

                    context.Products.Add(new Product
                    {
                        Name = "Laptop",
                        Stock = 10,
                        Category = electronics
                    });

                    context.SaveChanges();
                }

                Console.WriteLine("Database created and data inserted.");
            }
        }
    }
}
