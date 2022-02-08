using System.Collections.Generic;

namespace MyShopForHair.Core.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}