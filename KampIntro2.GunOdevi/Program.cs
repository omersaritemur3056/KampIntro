using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro2.GunOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductCategory = "Kadın Pantolon";
            product1.ProductName = "Trendyol Curve";
            product1.ProductDescription = "Siyah Pileli Dokuma Pantolon";
            product1.ProductPrice = 212.49;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductCategory = "Kadın Pantolon";
            product2.ProductName = "Havoş";
            product2.ProductDescription = "Bej Premium Keten Pantolon";
            product2.ProductPrice = 376.92;

            Product[] products = new Product[] { product1, product2 };

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine(products[j].ProductName);
            }

            Console.WriteLine("--------------------------------------");

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductPrice);
            }

            Console.WriteLine("---------------------------------------");

            int i = 0;

            while (i < products.Length)
            {
                Console.WriteLine(products[i].ProductDescription);
                i++;
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
    }
}
