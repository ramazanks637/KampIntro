using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Odev5
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName+"Kampanyalara eklendi");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + "Kampanyalardan silindi");

        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + "Kampanyası Güncellendi");

        }
    }
}
