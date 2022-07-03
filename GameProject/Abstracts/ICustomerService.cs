using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    internal interface ICustomerService
    {
        void Save(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
