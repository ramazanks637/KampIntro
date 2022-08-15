using Gercek_Hayatta_Interface_ve_Abstract.Abstract;
using Gercek_Hayatta_Interface_ve_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gercek_Hayatta_Interface_ve_Abstract.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _CustomerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _CustomerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_CustomerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            throw new Exception("Not a valid person");
        }

    }
}
