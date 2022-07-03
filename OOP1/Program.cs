using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};
            //bu da bir çeşit kullanım. Collection ile array mantığı gibi düşün

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //Console.WriteLine(product1.ProductName); Bunun sonucu kamera olma sebebi Add() metotu uygulamasından dolayı referansı değişti

            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);
            //işte returnlu olan metotun avantajı
            //void yapsaydık sonrasında oradan devam edip başka işlem yapamazsın ama return
            //edersen o metotu çağırıp onunla daha farklı ya da yeni işlemler yapabilirsin. Bu
            //yüzden metotlarda eğer bir veri, değişkenle çalışıyorsak return edip onu kullanır nihai
            //hedefimize ulaşırız.



        }
    }
}
