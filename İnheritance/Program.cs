using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{FirstName = "Ömer", LastName = "Sarıtemur"},
                new Student{FirstName = "Ümit"},
                new Person()
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
