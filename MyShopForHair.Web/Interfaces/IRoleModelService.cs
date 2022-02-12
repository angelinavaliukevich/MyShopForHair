using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
   public interface IRoleModelService
    {
        IEnumerable<RoleModel> Get();
        RoleModel Get(int id);
        int Add(RoleModel role);
        void Update(RoleModel role);
        void Delete(int id);
    }
}
