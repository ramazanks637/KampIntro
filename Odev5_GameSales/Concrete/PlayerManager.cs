using Odev5_GameSales.Abstract;
using Odev5_GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_GameSales.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;

        }

        List<Player> players = new List<Player>();
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine();
                Console.WriteLine("Oyuncu Veritabanına Kayıt Edildi: " + player.FirstName);
                Console.WriteLine("-------------------------------------------------------");
                players.Add(player);

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Oyuncu Veritabanına Kayıt Edilemedi: " + player.FirstName);
            }
        }

        public void Delete(Player player)
        {
            players.Remove(player);
            Console.WriteLine();
            Console.WriteLine(player.FirstName + " Oyuncusu Silindi.");
            ListPlayer();
        }

        public void Update(Player player)
        {
            Console.WriteLine();
            Console.WriteLine(player.FirstName + " Oyuncusu Güncellendi.");
            ListPlayer();
        }

        public void ListPlayer()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Veritabanına Kayıtlı Oyuncular");
            Console.WriteLine("-------------------------------");
            foreach (Player player in players)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName);
            }
            Console.WriteLine("--------------------------------");

        }
    }
}
