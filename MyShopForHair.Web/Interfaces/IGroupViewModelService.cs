using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
   public interface IGroupViewModelService
    {
        int Add(GroupViewModel groupViewModel);
        void Edit(GroupViewModel groupViewModel);
        IEnumerable<GroupViewModel> GetAll();
        GroupViewModel GetById(int id);
    }
}
