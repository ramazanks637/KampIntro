using Odev5_GameSales.Abstract;
using Odev5_GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_GameSales.Concrete
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine(campaign.Name + " Kampanyalara eklendi");
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine(campaign.Name + " Kampanyalardan silindi");
            CampaignList();
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Kampanya bilgileri güncellendi");
            CampaignList();
        }

        public void CampaignList()
        {
            int i = 1;
            Console.WriteLine("Güncel Kampanyalar: ");
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine(i +") " + campaign.Name);
                i++;
            }
        }
    }
}
