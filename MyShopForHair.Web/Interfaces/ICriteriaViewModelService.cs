using MyShopForHair.Core.Entities;
using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
    public interface ICriteriaViewModelService
    {
        int Add(CriteriaViewModel criteriaViewModel);
        void Edit(CriteriaViewModel criteriaViewModel);
        IEnumerable<CriteriaViewModel> GetAll();
        CriteriaViewModel GetById(int id);
    }
}
