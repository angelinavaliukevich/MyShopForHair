using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
    public interface IBrandViewModelService
    {
        int Add(BrandViewModel brandViewModel);
        void Edit(BrandViewModel brandViewModel);
        IEnumerable<BrandViewModel> GetAll();
        BrandViewModel GetById(int id);
    }
}
