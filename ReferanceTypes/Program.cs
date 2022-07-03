using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, boolean, enum, float value types yani değer tiplerdir
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi 1 : " + sayi1);

            //arrays, classes, interfaces... referance types
            int[] sayilar = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar[0] = " + sayilar[0]);


            Person person = new Person();
            Person person2 = new Person();
            person2.FirstName = "Ömer";

            person2 = person;
            person.FirstName = "Faruk";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Ümit";
            customer.CreditCardNumber = "1234566644";
            Employee employee = new Employee();
            employee.FirstName = "Nazmiye";

            //customer = employee; bu kızar çünkü farklı classlarda referans veremeyiz

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);
            //burası dikkate değerdir; Üstteki kızarken bu kızmadı çünkü person ve customer
            //aslında aynıdır(parent-child) ama diğeri child child olduğundan tam aynı olmazlar
            //işte bu yüzden adreslerini yani referanslarını birbirine verip eşitleyemedik

            //boxing tekniğiyle basım sırasında referansları kullanarak eşitleme yapabiliriz
            //genel parantez sebebi ise CreditCardNumberi Person'da yaptık. Normalde
            //olmayacak şeyi referansla yapabilmeyi denedik. Yani Baseyi genişlettik...
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
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
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        //Yukarıda baseyi genişletme tricki bu metot içindi. Add operasyonunu tek bir classa
        //bağlı kalmadan hepsine yapmamızı sağladı. Basenin darlığı sorun olurdu veya bunu 
        //yapmasaydık her bir class için aynı metotları tekrar tekrar yazıp kod kalabalıklığı yapardık

        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " eklenmiştir.");
        }
    }
}
