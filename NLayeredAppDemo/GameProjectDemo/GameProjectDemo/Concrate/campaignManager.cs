using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrate
{
    public class campaignManager : ICampaignService
    {
        public void Add(campaign campaign)
        {
            Console.WriteLine("yeni kampanya eklendi."+campaign.campaignName);
        }

        public void Remove(campaign campaign)
        {
            Console.WriteLine("kampanya kaldırıldı." + campaign.campaignName);
        }

        public void Update(campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi." + campaign.campaignName);
        }
    }
}
