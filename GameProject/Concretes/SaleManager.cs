using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    internal class SaleManager : ISaleService
    {
        public void AddSalePromotion(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " oyuncusu için x oyuncumuz için kampanya mevcuttur!");
        }

        public void RemoveSalePromotion(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Oyuncumuzun kampanyası sonlanmıştır.");
        }

        public void Sale(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " oyuncumuz için satış yapılmıştır.");
        }

        public void UpdateSalePromotion(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " oyuncumuzun kampanyası güncellenmiştir.");
        }
    }
}
