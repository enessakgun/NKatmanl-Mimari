using GameProjectDemo.Concrate;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                FirstName="enes ",
                LastName="akgün ",
                BirthdayYear=new DateTime(2000,10,16 ),
                TcNo=10009595955
            };

            Gamer gamer2 = new Gamer()
            {
                FirstName = "ahmet ",
                LastName = "çay ",
                BirthdayYear = new DateTime(1999, 1, 18 ),
                TcNo = 10009555464,
               
            };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            Console.WriteLine("\n");
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer2);
            Console.WriteLine("\n");

            Game game1 = new Game()
            {
                GameId = 1 ,
                GameName="GTA ",
                GamePrice=150
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Remove(game1);
            Console.WriteLine("\n");
           

            campaign campaign1 = new campaign()
            {
                campaignId = 1,
                campaignName=" indirim50 "
            };
            campaignManager campaignManager = new campaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Remove(campaign1);
            Console.WriteLine("\n");

            Sales sales1 = new Sales()
            {
                SalesId = 1,
                GamePrice = 150
            };
            SalesManager salesManager = new SalesManager();
            salesManager.Sale(sales1,gamer1,game1,campaign1);

            Console.ReadLine();


            


        }
    }
}
