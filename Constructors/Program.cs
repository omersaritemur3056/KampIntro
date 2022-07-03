using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        //Constructor newlendiği zaman ilk seferde ve bir kez çalışır
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Ömer", LastName = "Sarıtemur", City = "İstanbul"};

            Customer customer2 = new Customer(2,"Ümit","Sarıtemur","İstanbul"); 
            //bu iki yazım şekliylede kullanılabilir. alttaki iki ctor ile sağladık
            //bu arada ilk newlemede normal parantez koysak da olurdu süslüden önce


        }

        
    }

    class Customer
    {
        //ctor ile kısayolla constructor açılabilir
        //hani newlerken sağdaki parantez var ya işte o default bir boş constructor çağırır 
        //hiç yazılmamışsa
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }

        public Customer(int ıd, string firstName, string lastName, string city)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            //şu this mantığı yapılmazsa ikinci kullanımda verdiğimiz parametreler boşa gider.
            //constructor parametreleri camelCase yazılır, proplar PascalCase ile.
            Console.WriteLine("Bir yapıcı blok daha çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
