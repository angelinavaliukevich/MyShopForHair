using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
    public interface ICriteriaService
    {
        int Add(Criteria criteria);
        void Edit(Criteria criteria);
    }
}
