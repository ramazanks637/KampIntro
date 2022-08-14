using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Odev5
{
    class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName+" Kişisi Eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " Kişisi Silindi");

        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " Kişisi Güncellendi");

        }

    }
}
