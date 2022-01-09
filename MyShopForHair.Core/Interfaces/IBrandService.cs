using MyShopForHair.Core.Entities;

namespace MyShopForHair.Core.Services
{
    public interface IBrandService
    {
        int Add(Brand brand);
        void Edit(Brand brand);
    }
}