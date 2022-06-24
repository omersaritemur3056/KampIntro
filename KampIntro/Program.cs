using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği. C# dilinde stringler çift tırnak ile verilir
            //DRY kendini tekrarlamaaynı işleri birden fazla yazma, yazılanı çağır
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            //koşullar kullanıp çorba etmek yerine bu önemli bool değişkenini kullanabilirz
            bool sistemeGirişYapılmisMi = false;

            if (sistemeGirişYapılmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonları");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


        }
    }
}
