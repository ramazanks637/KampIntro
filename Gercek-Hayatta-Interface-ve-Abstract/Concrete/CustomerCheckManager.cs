using Gercek_Hayatta_Interface_ve_Abstract.Abstract;
using Gercek_Hayatta_Interface_ve_Abstract.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gercek_Hayatta_Interface_ve_Abstract.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
        }
    }
}
