﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
   public interface IRepository<TEntity>
        where TEntity : class
    {
        TEntity Get(int id);
        IList<TEntity> Get(ISpecification<TEntity> specification);
        IList<TEntity> List();
        IList<TEntity> List(ISpecification<TEntity> specification);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
