using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
   public interface IUserService
    {
        int Add(User user);
        User Get(int id);
        User Get(string login);
    }
}
