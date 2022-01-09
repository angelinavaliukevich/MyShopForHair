using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Web.Interfaces;
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
    }
}
