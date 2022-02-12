using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
    public interface IRoleViewModelService
    {
        int Add(RoleModel roleViewModel);
        void Edit(RoleModel role);
        RoleModel GetById(int id);
    }
}
