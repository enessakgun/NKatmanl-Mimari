using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class campaign:IEntity
    {
        public int campaignId { get; set; }
        public string campaignName { get; set;}
    }
}
