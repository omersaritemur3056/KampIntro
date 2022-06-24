using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Product
    {
        //Property - özellik

        private string name;

        public int Id { get; set; }
        public string Name { get; set; }
        //public string Name { get { return name; } set { name = "Enfes"; } }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
