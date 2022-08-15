using System;
using Odev5_GameSales.Adapters;
using Odev5_GameSales.Concrete;
using Odev5_GameSales.Entities;

namespace Odev5_GameSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() {FirstName = "Ramazan",LastName = "Köse",DateOfBirth = new DateTime(1999, 12, 13),Id = 1,NationaltyId = "35953264704"};
            Player player2 = new Player() {FirstName = "Muhammet",LastName = "Duyar",DateOfBirth = new DateTime(1999, 10, 13),Id = 2,NationaltyId = "11111111111"};
            Player player3 = new Player() {FirstName = "Alper",LastName = "sargın",DateOfBirth = new DateTime(2002, 06, 25),Id = 3,NationaltyId = "38974789690"};

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);
            playerManager.Add(player3);
            playerManager.Delete(player2);
            playerManager.Update(player3);

            Campaign campaign1 = new Campaign() { Id = 1, Name = "Beleş var saldırın", CampaignAmount = 100 };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "yüzde 50 bizden", CampaignAmount = 50 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign2);

            Game game1 = new Game() {Id=1,GameName="The Forest",GameStudio="Rockstar",GamePrice=15 };
            Game game2 = new Game() {Id=2,GameName="Cyberpunk",GameStudio="CD game",GamePrice=250 };
            Game game3 = new Game() {Id=3,GameName="Spider-Man Remaster",GameStudio="Marvel Studio",GamePrice=500 };

            OrderManager orderManager = new OrderManager();
            orderManager.GameSales(player1, game2, campaign2);


        }
    }
}
