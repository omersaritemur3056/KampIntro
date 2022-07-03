using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    internal interface ISaleService
    {
        void Sale(Customer customer);
        void AddSalePromotion(Customer customer);
        void RemoveSalePromotion(Customer customer);
        void UpdateSalePromotion(Customer customer);
    }
}
