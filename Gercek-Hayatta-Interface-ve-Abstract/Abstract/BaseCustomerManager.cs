using Gercek_Hayatta_Interface_ve_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gercek_Hayatta_Interface_ve_Abstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Veri tabanına kaydedildi: " + customer.FirstName);
        }
    }
}
