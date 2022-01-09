using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyShopForHair.Core.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepository<Brand> brandRepository;
        public BrandService(IRepository<Brand> brandRepository)
        {
            this.brandRepository = brandRepository;
        }

        public int Add(Brand brand)
        {
            brandRepository.Add(brand);

            return brand.Id;
        }

        public void Edit(Brand brand)
        {
            
        }
    }
}
