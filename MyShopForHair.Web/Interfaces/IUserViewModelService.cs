using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
   public interface IUserViewModelService
    {
        int Add(UserViewModel userViewModel);
        UserViewModel GetById(int value);
        void Edit(UserViewModel user);
        UserViewModel GetEmpty();
    }
}
