using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrate
{
    public class GamerManager : IGamerService
    {

        public void Add(Gamer gamer)
        {
            Console.WriteLine("kullanıcı ekleme başarılı."+gamer.FirstName+""+gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kullanıcı silme başarılı." + gamer.FirstName + "" + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kullanıcı güncelleme başarılı." + gamer.FirstName + "" + gamer.LastName);
        }
    }
}
