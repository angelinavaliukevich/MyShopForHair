using Microsoft.EntityFrameworkCore;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Infrastructure.Data.Repositories
{
    public class EFRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {

        private readonly CatalogDbContext DbContext;
        public EFRepository(CatalogDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public TEntity Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
            DbContext.SaveChanges();
            DbContext.Entry(entity).State = EntityState.Detached;

            return entity;
        }


        public void Delete(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
            DbContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            var entity = DbContext.Set<TEntity>().Find(id);
            DbContext.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public IList<TEntity> Get(ISpecification<TEntity> specification)
        {
            return specification
                .Applay(DbContext.Set<TEntity>())
                .AsNoTracking()
                .ToList();           
        }

        public IList<TEntity> List()
        {
            return DbContext.Set<TEntity>().ToList();
        }

        public IList<TEntity> List(ISpecification<TEntity> specification)
        {
            return specification
               .Applay(DbContext.Set<TEntity>())
               .AsNoTracking()
               .ToList();
        }

        public void Update(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}

