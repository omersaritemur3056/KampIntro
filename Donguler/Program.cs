using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Sayfa sonu");

            string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java Programlama", "Python programlama"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa sonu");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
