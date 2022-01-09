using Microsoft.AspNetCore.Mvc;
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
        }
        public int Add(BrandViewModel brandViewModel)
        {
            throw new NotImplementedException();
        }

        
        public void Edit(BrandViewModel brandViewModel)
        {
            
        }

        public IEnumerable<BrandViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public BrandViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
