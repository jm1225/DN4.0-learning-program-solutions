using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSearchFuntion
{
    public class Product
    {
        public int ProdId { get; set; }
        public string Prod_name { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProdId = id;
            Prod_name = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"{ProdId} - {Prod_name} ({Category})";
        }
    }
}
