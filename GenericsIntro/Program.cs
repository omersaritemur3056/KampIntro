using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList isimler = new MyList(); bu artık olmaz generik <> ve joker bir type olan T var

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ömer");

        }
    }
}
