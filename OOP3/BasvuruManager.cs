using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Operasyonlarda bir işlem sırasında başka bir işlem varsa ve o operasyonun ortak
        //özellikleri tutan bir base ya da imza varsa ki genelde imza olurlar onu böyle 
        //parametre olarak getirir ve hepsinin referansını tuttuğundan çok yönlü avantaj verir

        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme kodları...
            //

            krediManager.Hesapla();
            //interface tipinde parametre atadık ve o değişkenle işlem yaptık fakat bu
            //hepsinin referansını tuttuğundan çeşitli yerlerde bu mesela taşıt, ihtiyaç,
            //KonutKrediManager gibi şeylere dönüştürür yani onları değişken olarak 
            //o tipte verebiliriz.

            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
