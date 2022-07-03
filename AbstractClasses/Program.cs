using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvAhalisi evAhalisi1 = new EvAhalisi();
            HomeService homeService = new HomeManager();

            evAhalisi1.Id = 1;
            evAhalisi1.FullName = "Ömer Sarıtemur";
            evAhalisi1.ObezMi = false;
            evAhalisi1.SağlığıYerindeMi = false;

            EvAhalisi evAhalisi2 = new EvAhalisi();
            evAhalisi2.Id = 2;
            evAhalisi2.FullName = "Nazmiye Sarıtemur";
            evAhalisi2.ObezMi = true;
            evAhalisi2.SağlığıYerindeMi = false;

            homeService.TemizlikYap(evAhalisi2);

            homeService.YemekYap(evAhalisi1);
        }
    }
}
