using Gercek_Hayatta_Interface_ve_Abstract.Abstract;
using Gercek_Hayatta_Interface_ve_Abstract.Concrete;
using Gercek_Hayatta_Interface_ve_Abstract.Entities;
using System;

namespace Gercek_Hayatta_Interface_ve_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "35953264704" });

        }
    }
}






