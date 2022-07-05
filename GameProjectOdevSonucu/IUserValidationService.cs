using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectOdevSonucu
{
    internal interface IUserValidationService
    {
        //burada gamer dedik ama daha profesyoneli User basesi açıp onu getirmek olurdu
        //çünkü sadece oyuncuları değil çalışanlar vs. için de olurdu bir de soyutlamada 
        //daha başarılı bir kod yazılmış olur.
        bool Validate(Gamer gamer);
    }
}
