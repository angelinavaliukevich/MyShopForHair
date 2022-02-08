using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using MyShopForHair.Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Services
{
   public class ProductsService : IProductsService
    {
        private readonly IRepository<Products> productsRepository;
        private readonly IRepository<Criteria> criteriaRepository;
        private readonly IRepository<Brand> brandRepository;
        public ProductsService(IRepository<Products> productsRepository, IRepository<Criteria> criteriaRepository, IRepository<Brand> brandRepository)
        {
            this.productsRepository = productsRepository;
            this.criteriaRepository = criteriaRepository;
        }

        public int Add(Products products)
        {
            productsRepository.Add(products);
            return products.Id;
        }

        public void Edit(Products products)
        {
            productsRepository.Update(products);
        }
    }
}
