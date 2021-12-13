using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
   public interface ISpecification <TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> Applay(IQueryable<TEntity> query);
    }
}
