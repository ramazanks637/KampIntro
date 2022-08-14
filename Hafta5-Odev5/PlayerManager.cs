using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Odev5
{
    class PlayerManager : IPlayerService
    {
        List<Player> players;
        public void Add(List<Player> players)
        {
            Console.WriteLine(player.FirstName+ " Kullanıcısı eklendi");
            players.Add(player);
            foreach (var playerlar in players)
            {
                Console.WriteLine(playerlar.FirstName);
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kullınıcı Bilgileri Güncellendi");
        }

        public void ViewPlayer(List<Player> players)
        {
            foreach (var playerlar in players)
            {
                Console.WriteLine(playerlar.FirstName);
            }
        }

       
    }
}
