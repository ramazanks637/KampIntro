using MernisServiceReference;
using Odev5_GameSales.Abstract;
using Odev5_GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_GameSales.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
        
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationaltyId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        
        }
    }
}
