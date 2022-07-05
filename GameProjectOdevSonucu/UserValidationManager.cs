using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdevSonucu
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            //bu if içindeki koşul simule kısmıydı
            if (gamer.BirthYear == 1992 && gamer.FirstName == "Ömer" && gamer.LastName == "Sarıtemur" && gamer.IdentityNumber == 51931157226)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
