using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Interfaces
{
    public interface IProductsViewModelService
    {
        int Add(ProductsViewModel productsViewModel);
        IEnumerable<ProductsViewModel> Filter(ProductsViewModel productsViewModel);
        void Edit(ProductsViewModel productsViewModel);
        IEnumerable<ProductsViewModel> GetAll();
        ProductsViewModel GetById(int id);
        ProductsViewModel GetEmpty();
        void DeleteProducts(int id);
    }
}
