using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
   public interface IGroupService
    {
        int Add(Group group);
        void Edit(Group group);
    }
}
