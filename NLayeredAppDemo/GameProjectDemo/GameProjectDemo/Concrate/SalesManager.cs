using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrate
{
    public class SalesManager : ISalesService
    {
        public void Sale(Sales sales, Gamer gamer, Game game, campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+" kullanıcısına "+game.GameName+" oyunu "+
                campaign.campaignName+" kampanyası dahilinde "+sales.GamePrice+" tl fiyatına satılmıştır. ");
        }
    }
}
