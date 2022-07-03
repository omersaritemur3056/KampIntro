using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal abstract class HomeService
    {
        public void YemekYap(EvAhalisi evAhalisi)
        {
            Console.WriteLine(evAhalisi.FullName + " Yemek yapacak.");
        }

        public void KapıyaBak(EvAhalisi evAhalisi)
        {
            Console.WriteLine("Kapıya bakıldı.");
        }

        public virtual void CayYap(EvAhalisi evAhalisi)
        {
            Console.WriteLine("Çay koyuldu.");
        }

        public abstract void AlisVerisYap(EvAhalisi evAhalisi);
        public abstract void TemizlikYap(EvAhalisi evAhalisi);
        
    }
}
