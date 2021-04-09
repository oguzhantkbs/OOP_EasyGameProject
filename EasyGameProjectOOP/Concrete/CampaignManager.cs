using EasyGameProjectOOP.Abstract.CampaignOperations;
using EasyGameProjectOOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameProjectOOP.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Campaign campaign1 = new Campaign();
            campaign1.CompaignName = campaign.CompaignName;
            Console.WriteLine(campaign.CompaignName+" Kampanyası başarı ile eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Campaign campaign1 = new Campaign();
            campaign1.CompaignName = "";
            Console.WriteLine(campaign.CompaignName + " Kampanyası başarı ile silindi");
        }

        public void Update(Campaign campaign)
        {
            Campaign campaign1 = new Campaign();
            campaign1.CompaignName = campaign.CompaignName;
            Console.WriteLine(campaign.CompaignName + " Kampanyası başarı ile güncellendi");
        }
    }
}
