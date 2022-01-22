using MyShopForHair.Core.Entities;
using System.Collections.Generic;

namespace MyShopForHair.Core.Services
{
    public interface IBrandService
    {
        int Add(Brand brand);
        void Edit(Brand brand);
        IEnumerable<object> List();
    }
}