using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
    public interface IProductsService
    {
        int Add(Products products);
        void Edit(Products products);
        IEnumerable<Products> Filter(Products products);
    }
}
