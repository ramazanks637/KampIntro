using System;

namespace Hafta5_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() {Id=1, FirstName = "Ramazan", LastName = "Köse", NationalId = 15426578412, DayToBirthday = 1999 };
            Player player2 = new Player() {Id=1, FirstName = "Muhammet", LastName = "Duyar", NationalId = 15426578412, DayToBirthday = 1999 };
            Player player3 = new Player() {Id=1, FirstName = "Rıdvan", LastName = "Eldem", NationalId = 15426578412, DayToBirthday = 1999 };
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Update(player2);
            playerManager.Delete(player3);

            Campaing campaing1 = new Campaing() { CampaingName = "beleşçiler gelmeden", DiscauntPrice = 10, Id = 1 };
            Game game1 = new Game() { Id = 1, Name = "the Forest", StudioName = "Rockstar", UnitPrice = 15, CampaingPrice = 1 };
            CampaingManager campaingManager = new CampaingManager();
            SalesManager salesManager = new SalesManager();

            campaingManager.Add(campaing1);
            salesManager.Sales(player1, game1, campaing1);
        }
    }
}
