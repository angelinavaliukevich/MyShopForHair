using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandViewModelService brandViewModelService;
        public BrandController(IBrandViewModelService brandViewModelService)
        {
            this.brandViewModelService = brandViewModelService;
        }
        
    }
}
