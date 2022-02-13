using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Specification
{
    public class ProductsFilterSpecification : ISpecification<Products>
    {
        private readonly IRepository<Products> productsRepository;
        public IList<string> Includes =>
    new List<string> {};
        public string DescriptionSubs { get; set; }
        public ProductsFilterSpecification(Products p) {
            this.productsViewModel = p;
        }
        public Products productsViewModel { get; set; }
        public int? MaxCount { get; set; }
        public IQueryable<Products> Apply(IQueryable<Products> query)
        {

            IQueryable<Products> l = query;

            if (productsViewModel.Name != null)
                l = l.Where(i => i.Name.Contains(productsViewModel.Name));
            if (productsViewModel.Description != null)
                l = l.Where(i => i.Description.Contains(productsViewModel.Name));
            if (productsViewModel.Price > 0)
                l = l.Where(i => i.Price == productsViewModel.Price);
            if (productsViewModel.BrandId > 0)
                l = l.Where(i => i.BrandId == productsViewModel.BrandId);
            if (productsViewModel.GroupId > 0)
                l = l.Where(i => i.GroupId == productsViewModel.GroupId);
            if (productsViewModel.CriteriaId > 0)
                l = l.Where(i => i.Criteria.Id == productsViewModel.CriteriaId);

            query = l;

            if (!string.IsNullOrEmpty(DescriptionSubs))
                query = query.Where(p => p.Description.Contains(DescriptionSubs));
            if (MaxCount.HasValue && MaxCount > 0)
                query = query.Where(p => p.Description.Length <= MaxCount);
            return query;

        }
    }
}
