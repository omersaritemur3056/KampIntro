using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdevSonucu
{
    internal class GamerManager : IGamerService
    {
        //bu değişken add metotunda da açğırılabilir fakat doğru bir kullanım olmazdı
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {          
            _userValidationService = userValidationService;
        }

        //MicroService dışarıdan kullanılan sistem tıpkı Mernis gibi
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
