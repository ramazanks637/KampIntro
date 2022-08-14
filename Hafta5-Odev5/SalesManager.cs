using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Odev5
{
    class SalesManager : IGameService
    {
        public void Sales(Player player,Game game,Campaing campaing)
        {
            Console.WriteLine(player.FirstName +" kişisi"+ game.Name+" Adlı oyunu"+campaing.CampaingName+" Kampanyasından yararlanarak satın aldı.");
        }
    }
}
