using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdevSonucu
{
    internal class Program
    {
        //Engin hoca ile yapıldı...
        //önce varlığı(Entity) bul sonra operasyonlar...
        //ödevi tamamlarken CampaignManager ve OrderManager gibi sınıflar da oluşturulmalı
        //hatta Game diye bir varlık dahi yazabiliriz
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1993, FirstName = "Ömer", LastName = "Sarıtemur", IdentityNumber = 51931157226 });


        }
    }
}
