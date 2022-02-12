using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using MyShopForHair.Core.Services;
using MyShopForHair.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Models
{
    public class BrandViewModelService : IBrandViewModelService
    {
        private readonly IBrandService brandService;
        private readonly IRepository<Brand> brandRepository;
        public BrandViewModelService(IBrandService brandService, IRepository<Brand> brandRepository)
        {
            this.brandService = brandService;
            this.brandRepository = brandRepository;
        }



        public int Add(BrandViewModel brandViewModel)
        {
            return brandService.Add(ConvertToModel(brandViewModel));
        }

        public void Edit(BrandViewModel brandViewModel)
        {
            brandService.Edit(ConvertToModel(brandViewModel));
        }


        public void DeleteBrand(int id)
        {
            Brand brand = brandRepository.List().Where(i => i.Id == id).FirstOrDefault(); 
            if (brand!=null)
            brandRepository.Delete(brand);
            //return null;
        }

        public IEnumerable<BrandViewModel> GetAll()
        {
            return brandRepository.List().Select(ConvertToViewModel);
        }

        public BrandViewModel GetEmpty()
        {
            return ConvertToViewModel(new Brand());
        }

        public BrandViewModel GetById(int id)
        {
            var brand = brandRepository.Get(id);
            return brand != null ? ConvertToViewModel(brand) : null;
        }
        private BrandViewModel ConvertToViewModel(Brand brand)
        {
            return new BrandViewModel
            {
                Id = brand.Id,
                Name = brand.Name,
            };
        }

        private Brand ConvertToModel(BrandViewModel brandViewModel)
        {
            return new Brand
            {
                Id = brandViewModel.Id.HasValue ? brandViewModel.Id.Value : 0,
                Name = brandViewModel.Name
            };

        }
    }
}
