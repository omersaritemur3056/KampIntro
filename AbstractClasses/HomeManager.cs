using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class HomeManager : HomeService
    {
        public override void AlisVerisYap(EvAhalisi evAhalisi)
        {
            Console.WriteLine(evAhalisi.FullName +" alışveriş ona kitlendi. :) ");
        }

        public override void TemizlikYap(EvAhalisi evAhalisi)
        {
            Console.WriteLine(evAhalisi.FullName + " temizlik yaptı.");
        }

        public override void CayYap(EvAhalisi evAhalisi)
        {
            Console.WriteLine("Çay konuldu.");
        }
    }
}
