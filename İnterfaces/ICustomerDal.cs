using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added to Sql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from Sql");
        }

        public void Update()
        {
            Console.WriteLine("Updated Sql");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added to Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Updated Oracle");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
