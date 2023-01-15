using System.Collections.Generic;

namespace ProductsShop.Models
{
    public class Database
    {
        public static List<Products> GetProductsList()
        {
            List<Products> products = new List<Products>
            {
                new Products
                {
                    ProductId = 1,
                    Name="Product 1",
                    Price=(decimal)100.00
                },
                new Products
                {
                    ProductId = 2,
                    Name="Product 2",
                    Price=(decimal)200.00
                },
                new Products
                {
                     ProductId = 3,
                    Name="Product 3",
                    Price=(decimal)300.00
                },
                new Products
                {
                     ProductId = 4,
                    Name="Product 4",
                    Price=(decimal)400.00
                },
                new Products
                {
                     ProductId = 5,
                    Name="Product 5",
                    Price=(decimal)500.00
                },
            };
            return products; 
        }
        public static Products GetProduct(string slug)
        {
            List<Products> products = Database.GetProductsList();
            foreach (Products p in products)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }
            return null;
        }
    }

}
