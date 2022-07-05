using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdevSonucu
{
    internal class NewEStateUserValidationManager : IUserValidationService
    {
        //interface sayesinde istediğimiz an farklı doğrulama sınıflarıyla çalışabiliyoruz
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
