using System.Collections.Generic;

namespace MyShopForHair.Core.Entities
{
   public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}