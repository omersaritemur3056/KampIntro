using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Çalışan eklendi.");
        }

        public void Update()
        {
            
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi.");
        }
    }


    class ProjectManager 
    {
        //parametre olarak interface vermek çok mantıklıdır. Kim onu implement ederse onları
        //zaten referansla çağırabilir
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
