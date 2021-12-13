using System.Collections.Generic;

namespace MyShopForHair.Core.Entities
{
    public class Criteria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdGroup { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}