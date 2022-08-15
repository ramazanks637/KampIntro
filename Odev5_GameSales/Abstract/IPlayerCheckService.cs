using Odev5_GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_GameSales.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
