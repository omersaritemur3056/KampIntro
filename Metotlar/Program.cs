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

//ref ve out keywordleri değiişken olarak tipin önüne yazılır ref int sayi = 10 gibi
//bu artık o değişkeni referans tip yapar. ref ve out arasındaki fark; ref'te değişkenlerin
//set edilmesi yani değerinin başta verilmesi gereklidir ki onu değiştirsin
//out öyle değildir, değişken olsun yeter. Tabii şu var out metotta varsa o metotta
//out olacak değişken bir kez set edilmeli yani değeri verilmelidir.

//Metot overloading şudur: Mesela bir toplama işlemi metotunda iki parametreli yazdın bir de
//aynı isimde üç parametreli yazarsan o metot çağırıldığında iki veya üç parametre alabilir.

//params keywordu sayesinde parametre olarak kısıtmaladan kurtulabiliriz. Mesela metota parametre
//verirken int sayi1, int sayi 2 yerine params int[] sayilar verirsek parametre sınırı ortadan kalkar.
// params en sağda olur tıpkı default değişken opsiyonu gibi ama öncesinde değer verilebilişr.
//Javascript gibi düşün. :)