using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Controllers
{
    public class CriteriaController : Controller
    {
        private readonly ICriteriaViewModelService criteriaViewModelService;
        public CriteriaController(ICriteriaViewModelService criteriaViewModelService)
        {
            this.criteriaViewModelService = criteriaViewModelService;
        }
        public IActionResult Add()
        {
            return View(criteriaViewModelService.GetEmpty());
        }

        [HttpPost]
        public IActionResult Add(CriteriaViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            criteriaViewModelService.Add(viewModel);

            return RedirectToAction("Add", "Home");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var criteria = id.HasValue ? criteriaViewModelService.GetById(id.Value) : new CriteriaViewModel();

            return View(criteria);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CriteriaViewModel criteria)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var id = criteria.Id;

            if (id == null)
            {
                id = criteriaViewModelService.Add(criteria);
            }
            else
            {
                criteriaViewModelService.Edit(criteria);
            }

            return RedirectToAction(nameof(Index), new { id });
        }
    }
}