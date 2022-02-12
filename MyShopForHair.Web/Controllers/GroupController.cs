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

        public IActionResult Index()
        {
            return View(groupViewModelService.GetAll());
        }
        public IActionResult Delete(int? id)
        {
            int deleteid = 0;
            if (id.HasValue)
            {
                deleteid = id.Value;

               groupViewModelService.DeleteGroup(deleteid);
            }
            return View(groupViewModelService.GetAll());
        }
        public IActionResult Add()
        {
            return View(groupViewModelService.GetEmpty());
        }

        [HttpPost]
        public IActionResult Add(GroupViewModel viewModel)
        {
            /*if (!ModelState.IsValid)
            {
                View(viewModel);
            }*/

            groupViewModelService.Add(viewModel);

            return RedirectToAction("Index", "Group");
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
