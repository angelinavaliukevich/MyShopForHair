using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Entities
{
   public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Criteria Criteria { get; set; }
    }
}
