using DevFramework.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DevFramework.Core.DataAccess.EntitiyFramework
{
    public class EfEntityRepositoryBase<TEntitiy, Tcontext> : IEntityRepository<TEntitiy>
        where TEntitiy : class, IEntity, new()
        where Tcontext : DbContext, new()
    {
        public TEntitiy Add(TEntitiy entity)
        {
            using (var context = new Tcontext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(TEntitiy entity)
        {
            using (var context = new Tcontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntitiy Get(Expression<Func<TEntitiy, bool>> filter)
        {
            using (var context = new Tcontext())
            {
                return context.Set<TEntitiy>().SingleOrDefault(filter);
            }
        }

        public List<TEntitiy> GetList(Expression<Func<TEntitiy, bool>> filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null
                    ? context.Set<TEntitiy>().ToList()
                    : context.Set<TEntitiy>().Where(filter).ToList();
            }
        }

        public TEntitiy Update(TEntitiy entity)
        {
            using (var context = new Tcontext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
    }
}
