using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSearchFuntion
{
    public static class SearchFunction
    {
        public static Product LinearSearch(List<Product> products, string name)
        {
            foreach (var product in products)
            {
                if (product.Prod_name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(List<Product> products, string name)
        {
            products.Sort((a, b) => string.Compare(a.Prod_name, b.Prod_name, true));

            int left = 0;
            int right = products.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(name, products[mid].Prod_name, true);

                if (cmp == 0) return products[mid];
                if (cmp > 0) left = mid + 1;
                else right = mid - 1;
            }

            return null;
        }
    }
}
