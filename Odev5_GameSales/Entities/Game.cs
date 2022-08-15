using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_GameSales.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameStudio { get; set; }
        public int GamePrice { get; set; }

    }
}
