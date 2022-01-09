using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Services
{
    public class ProductsViewModelService : IProductsViewModelService
    {
        private readonly IProductsService productsService;
        private readonly IRepository<Criteria> criteriaRepository;
        public ProductsViewModelService(IProductsService productsService, IRepository<Criteria> criteriaRepository)
        {
            this.criteriaRepository = criteriaRepository;
            this.productsService = productsService;
        }
        public int Add(ProductsViewModel productsViewModel)
        {
            return productsService.Add(ConvertToModel(productsViewModel));
        }

        public void Edit(ProductsViewModel productsViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductsViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductsViewModel GetById(int id)
        {
            return ConvertToViewModel(new Products());

             Products ConvertToModel(ProductsViewModel productsViewModel)
            {
                return new Products
                {
                    Id = productsViewModel.Id.HasValue ? productsViewModel.Id.Value : 0,
                    Name = productsViewModel.Name,
                    Description = productsViewModel.Description,
                    Price = productsViewModel.Price,
                    BrandId = productsViewModel.BrandId
                };
            }

             ProductsViewModel ConvertToViewModel(Products products)
            {
                return new ProductsViewModel
                {
                    Id = products.Id,
                    Name = products.Name,
                    Description = products.Description,
                    Price = products.Price,
                    BrandId = products.BrandId
                   
                };
            }
        }
    }
}
