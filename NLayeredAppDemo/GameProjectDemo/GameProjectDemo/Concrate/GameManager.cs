using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrate
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("OYUN eklendi"+game.GameName);
        }

        public void Remove(Game game)
        {
            Console.WriteLine("OYUN kaldırıldı" + game.GameName);
        }

       
    }
}
