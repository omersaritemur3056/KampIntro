using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    internal interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
