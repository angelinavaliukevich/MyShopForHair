using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Core.Entities;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
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




        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                brandViewModelService.DeleteBrand(id.Value);
            }

            return View(brandViewModelService.GetAll());
        }

        public IActionResult Index()
        {
            return View(brandViewModelService.GetAll());
        }

        public IActionResult Add()
        {
            return View(brandViewModelService.GetEmpty());
            
        }

        [HttpPost]
        public IActionResult Add(BrandViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            brandViewModelService.Add(viewModel);

            return RedirectToAction("Index", "Brand");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var brand = id.HasValue ? brandViewModelService.GetById(id.Value) : new BrandViewModel();

            return View(brand);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BrandViewModel brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var id = brand.Id;

            if (id == null)
            {
                id = brandViewModelService.Add(brand);
            }
            else
            {
                brandViewModelService.Edit(brand);
            }

            return RedirectToAction(nameof(Index), new { id });
        }
    }
}
