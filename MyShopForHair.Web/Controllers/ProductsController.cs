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
    public class ProductsController : Controller
    {
        private readonly IProductsViewModelService productsViewModelService;
        private readonly IProductsService productsService;

        public ProductsController(IProductsViewModelService productsViewModelService, IProductsService productsService)
        {
            this.productsViewModelService = productsViewModelService;
            this.productsService = productsService;
        }

        public IActionResult Index()
        {
            return View(productsViewModelService.GetAll());
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            int deleteid = 0;
            if (id.HasValue)
            {
                deleteid = id.Value;
                productsViewModelService.DeleteProducts(deleteid);
            }
           return View(productsViewModelService.GetAll());

        }

        public IActionResult Add()
        {
            return View(productsViewModelService.GetEmpty());
        }


        public IActionResult Filter()
        {
            return View("Filter", productsViewModelService.GetEmpty());
        }
        [HttpPost]
        public IActionResult Add(ProductsViewModel viewModel)
        {
            /*if (!ModelState.IsValid)
            {
                return View(viewModel);
            }*/

            productsViewModelService.Add(viewModel);

            return RedirectToAction("Index", "Products");
        }


        [HttpPost]
        public IActionResult Filter(ProductsViewModel viewModel)
        {
            /*if (!ModelState.IsValid)
            {
                return View(viewModel);
            }*/

            IEnumerable<ProductsViewModel> model=productsViewModelService.Filter(viewModel);
            return View("FilterList", model);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var products = id.HasValue ? productsViewModelService.GetById(id.Value) : new ProductsViewModel();

            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductsViewModel products)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var id = products.Id;

            if (id == null)
            {
                id = productsViewModelService.Add(products);
            }
            else
            {
                productsViewModelService.Edit(products);
            }

            return RedirectToAction(nameof(Index), new { id });
        }
    }
}
