using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Core.Interfaces;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Controllers
{
    public class ProductsController
    {
        private readonly IProductsViewModelService productsViewModelService;
        private readonly IProductsService productsService;

        public ProductsController(IProductsViewModelService productsViewModelService, IProductsService productsService)
        {
            this.productsViewModelService = productsViewModelService;
            this.productsService = productsService;
        }

      /*  [HttpGet]
        public IActionResult Index(int id)
        {
            var products = productsViewModelService.GetById(id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        [HttpGet]
        public IActionResult List()
        {
            var products = productsViewModelService.GetAll();

            return View(products);

            [HttpGet]
            [Authorize(Roles = "admin")]
            IActionResult Edit(int? id)
            {
                var products = id.HasValue ? productsViewModelService.GetById(id.Value) : new ProductsViewModel();

                return View(products);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            [Authorize(Roles = "admin")]
           IActionResult Edit(ProductsViewModel products)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var id = products.Id;

                if (id == null || id == 0)
                {
                    id = productsViewModelService.Add(products);
                }
                else
                {
                    productsViewModelService.Edit(products);
                }

                return RedirectToAction(nameof(Index), new { id });
            }*/

        }
    }

