using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Çilek";
            product2.Price = 25;
            product2.Description = "Çilek gibi çilek! :) ";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("----------Metotlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.AddToCart(product1);
            sepetManager.AddToCart(product2);

            
        }
    }
}


//kendini tekrar ettirecek bir kod yapısıyla karşılaşacağımızı düşünürsek onları bir metot yapıp
//gerektiğinde çağırmak hatta genişletmek çok yararlı olacaktır