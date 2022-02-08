using System;
using System.Collections.Generic;

namespace MyShopForHair.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}