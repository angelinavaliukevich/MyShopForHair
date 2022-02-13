using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IRepository<Brand> brandRepository;
        private readonly IRepository<Group> groupRepository;
        private readonly IRepository<Criteria> criteriaRepository;
        
        public ProductsViewModelService(IProductsService productsService,
            IRepository<Products> productsRepository,
            IRepository<Brand> brandRepository,
            IRepository<Group> groupRepository,
            IRepository<Criteria> criteriaRepository
            )
        {
            this.productsRepository = productsRepository;
            this.productsService = productsService;
            this.brandRepository = brandRepository;
            this.groupRepository = groupRepository;
            this.criteriaRepository = criteriaRepository;
            
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
            IList<Products> l = productsRepository.List();
            return l.Select(ConvertToViewModel);
        }

       public IEnumerable<ProductsViewModel> Filter(ProductsViewModel pm)
        {
            

            Products tmp = new Products();
            tmp.Name = pm.Name;
            tmp.Description = pm.Description;
            tmp.Price = pm.Price;
            tmp.BrandId = pm.BrandId;
            tmp.GroupId = pm.GroupId;
            tmp.CriteriaId = pm.CriteriaId;
            IEnumerable<Products> ps= productsService.Filter(tmp);
            IList<ProductsViewModel> pmNew= new List<ProductsViewModel> {};
            foreach (Products p in ps) {
                ProductsViewModel pm2 = ConvertToViewModel(p);
                pmNew.Add(pm2);
            }
            return pmNew;
        }

        public ProductsViewModel GetEmpty()
        {
            var allbrend = brandRepository.List().Select(a =>
                                    new SelectListItem
                                    {
                                        Value = a.Id.ToString(),
                                        Text = a.Name
                                    }).ToList();
            allbrend.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "Select"
            });
            var allgroup = groupRepository.List().Select(a =>
                                    new SelectListItem
                                    {
                                        Value = a.Id.ToString(),
                                        Text = a.Name
                                    }).ToList();
            allgroup.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "Select"
            });

            var allcriteria = criteriaRepository.List().Select(a =>
                                     new SelectListItem
                                     {
                                         Value = a.Id.ToString(),
                                         Text = a.Name
                                     }).ToList();
            allcriteria.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "Select"
            });


            return new ProductsViewModel
            {
                Id = 0,
                Name = "",
                Description = "",
                Price = 0,
                BrandId = 0,
                GroupId = 0,
                CriteriaId = 0,
                Brand = null,
                Group = null,
                BrandsAll = allbrend,
                GroupsAll = allgroup,
                CriterialAll = allcriteria
            };
        }
        public void DeleteProducts(int id)
        {
            Products products = productsRepository.List().Where(i => i.Id == id).FirstOrDefault();
            if (products != null)
                productsRepository.Delete(products);
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
                BrandId = productsViewModel.BrandId,
                GroupId = productsViewModel.GroupId
            };
        }

        private ProductsViewModel ConvertToViewModel(Products products)
        {
            var gr = groupRepository.List().Where(i => i.Id == products.GroupId).FirstOrDefault();
            return new ProductsViewModel
            {
                Id = products.Id,
                Name = products.Name,
                Description = products.Description,
                Price = products.Price,
                BrandId = products.BrandId,
                GroupId = products.GroupId,
                GroupsAll = groupRepository.List().Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Name
                                  }).ToList(),
                BrandsAll = brandRepository.List().Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Name
                                  }).ToList(),
                CriterialAll = criteriaRepository.List().Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Name
                                  }).ToList(),
                Brand = brandRepository.List().Where(i => i.Id == products.BrandId).FirstOrDefault(),
                Group = (gr != null ? gr:null),
                Criteria = (gr!=null? criteriaRepository.List().Where(i => i.Id == gr.CriteriaID).FirstOrDefault():null),
            };
        }
    }
}
