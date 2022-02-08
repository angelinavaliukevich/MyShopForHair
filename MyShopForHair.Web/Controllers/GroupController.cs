using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupViewModelService groupViewModelService;
        public GroupController(IGroupViewModelService groupViewModelService)
        {
            this.groupViewModelService = groupViewModelService;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(GroupViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                View(viewModel);
            }

            groupViewModelService.Add(viewModel);

            return RedirectToAction("Add", "Home");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var group = id.HasValue ? groupViewModelService.GetById(id.Value) : new GroupViewModel();

            return View(group);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(GroupViewModel group)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var id = group.Id;

            if (id == null)
            {
                id = groupViewModelService.Add(group);
            }
            else
            {
                groupViewModelService.Edit(group);
            }

            return RedirectToAction(nameof(Index), new { id });
        }

    }
}
