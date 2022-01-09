using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Web.Interfaces;
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
    }
}
