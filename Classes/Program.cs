using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Ömer";
            customer.LastName = "Sarıtemur";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Faruk", LastName = "Sarıtemur"
            };

            System.Console.WriteLine(customer2.FirstName);


        }
    }
}
