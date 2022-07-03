using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            CustomerManager customerManager = new CustomerManager();

            customer1.Id = 1;
            customer1.FirstName = "Ömer";
            customer1.LastName = "Sarıtemur";

            customerManager.Add(customer1);

            customerManager.Delete(customer1);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " müşterisi sistemimize eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " müşterisi sistemimizden çıkarıldı.");
        }
    }
}
