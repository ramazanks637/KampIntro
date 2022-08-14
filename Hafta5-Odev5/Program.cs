using System;

namespace Hafta5_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() {Id=1,FirstName="Ramazan",LastName="Köse",NationalId= 38641264704, DayToBirthday=1999 };
            Player player2 = new Player() {Id=2,FirstName="Muhammet",LastName="Duyar",NationalId= 38641264704, DayToBirthday=1999 };
            Player player3 = new Player() {Id=3,FirstName="Rıdvan",LastName="Eldem",NationalId= 38641264704, DayToBirthday=1999 };
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

        }
    }
}
