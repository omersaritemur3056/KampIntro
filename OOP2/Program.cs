using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müsteri  -  Tüzel müşteri
            //SOLID

            GercekMüsteri gercekMüsteri1 = new GercekMüsteri();
            gercekMüsteri1.Id = 1;
            gercekMüsteri1.MusteriNo = "12345";
            gercekMüsteri1.Adi = "Ömer";
            gercekMüsteri1.Soyadi = "Sarıtemur";
            gercekMüsteri1.TcNo = "12345678910";

            TuzelMüsteri tuzelMüsteri1 = new TuzelMüsteri();
            tuzelMüsteri1.Id = 2;
            tuzelMüsteri1.MusteriNo = "54321";
            tuzelMüsteri1.SirketAdi = "Turşu imalat";
            tuzelMüsteri1.VergiNo = "1234567890";

            Müsteri müsteri3 = new GercekMüsteri();
            Müsteri müsteri4 = new TuzelMüsteri();

            MüsteriManager müsteriManager = new MüsteriManager();
            müsteriManager.Add(gercekMüsteri1);
            müsteriManager.Add(tuzelMüsteri1);


        }
    }
}
