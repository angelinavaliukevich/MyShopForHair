using System.Collections.Generic;

namespace MyShopForHair.Core.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort Price { get; set; }
        public int BrandId { get; set; }
        //public Brand Brand { get; set; }
        public int GroupId { get; set; }
        public int CriteriaId { get; set; }
        public Criteria Criteria { get; internal set; }
        public ICollection<Criteria> Criterias { get; set; }
    }
}