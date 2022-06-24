using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //bir yerde şu alttaki gibi parantez görüyorsan orada bir metot vardır
        //Encapsulation - Projende nesnelere ayırıp gerekeni kullanmak
        public void AddToCart(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + product.Name);
        }

        public void AddToCart2()
        {
            //bu kodda parametreleri ayrı ayrı değişken verdik
            //ama bir değişiklik geldiğinde herbiri ayrı ayrı sorun çıkardı
            //ama parametreyi Product verince sadece oraya stok adedini eklemek 
            //projeyi daha güzel bir hale getirdi
        }
    }
}
