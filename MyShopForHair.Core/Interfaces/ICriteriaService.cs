using MyShopForHair.Core.Entities;
using System.Collections.Generic;
namespace MyShopForHair.Core.Interfaces
{
    public interface ICriteriaService
    {
        int Add(Criteria criteria);
        void Edit(Criteria criteria);

    }
}
