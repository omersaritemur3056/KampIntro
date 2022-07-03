using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    internal abstract class BaseCustomerService : ICustomerService
    {
        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Oyuncu silindi : " + customer.FirstName);
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Oyuncu kaydedildi : " + customer.FirstName);
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı oyuncunun durumu güncellendi.");
        }

        
    }
}
