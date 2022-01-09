﻿using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
    public interface IRoleViewModelService
    {
        int Add(RoleViewModel roleViewModel);
        void Edit(RoleViewModel role);
        RoleViewModel GetById(int id);
    }
}
