using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; } //bu aslında foreign key olacak o yüzden hemen Temel kod olan Id'nin altına yazdık. Sonra ana attributeler
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
