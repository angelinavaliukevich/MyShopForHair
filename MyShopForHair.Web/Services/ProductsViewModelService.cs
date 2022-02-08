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
        private readonly IRepository<Products> productsRepository;
        public ProductsViewModelService(IProductsService productsService, IRepository<Products> productsRepository)
        {
            this.productsRepository = productsRepository;
            this.productsService = productsService;
        }
        public int Add(ProductsViewModel productsViewModel)
        {
            return productsService.Add(ConvertToModel(productsViewModel));
        }
        public void Edit(ProductsViewModel productsViewModel)
        {
            productsService.Edit(ConvertToModel(productsViewModel));
        }

        public IEnumerable<ProductsViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductsViewModel GetById(int id)
        {
            var products = productsRepository.Get(id);
            return products != null ? ConvertToViewModel(products) : null;
        }

        private Products ConvertToModel(ProductsViewModel productsViewModel)
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

        private ProductsViewModel ConvertToViewModel(Products products)
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
