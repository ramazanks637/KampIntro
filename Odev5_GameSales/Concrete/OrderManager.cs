using Odev5_GameSales.Abstract;
using Odev5_GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_GameSales.Concrete
{
    public class OrderManager : IOrderService
    {
        public void GameSales(Player player, Game game,Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu" + game.GameName + " oyununu" + campaign.Name + " Kampanyasından yararlanarak satın aldı");
        }
    }
}
