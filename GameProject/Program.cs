using GameProject.Abstracts;
using GameProject.Adapters;
using GameProject.Concretes;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ömer";
            customer1.LastName = "Sarıtemur";
            customer1.BirthYear = 1992;
            customer1.NationalityId = 51931157226;

            BaseCustomerService customerService = new CustomerManager(new MernisServiceAdapters());
            //customerService.Save(new Customer { NationalityId = 51931157226, FirstName = "Ömer", LastName = "Sarıtemur", BirthYear = 1992, Id = 1 });
            customerService.Save(customer1);

            ISaleService saleService = new SaleManager();
            saleService.Sale(customer1);
        }
    }
}
