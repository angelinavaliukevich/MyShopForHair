using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Specification
{
    class ProductsFilterSpecification : ISpecification<Products>
    {
        public IList<string> Includes =>
    new List<string> {};
        public string DescriptionSubs { get; set; }
        public int? MaxCount { get; set; }
        public IQueryable<Products> Apply(IQueryable<Products> query)
        {
            if (!string.IsNullOrEmpty(DescriptionSubs))
                query = query.Where(p => p.Description.Contains(DescriptionSubs));
            if (MaxCount.HasValue && MaxCount > 0)
                query = query.Where(p => p.Description.Length <= MaxCount);
            return query;

        }
    }
}
