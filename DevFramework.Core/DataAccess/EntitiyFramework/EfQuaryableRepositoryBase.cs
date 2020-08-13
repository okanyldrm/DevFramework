using DevFramework.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevFramework.Core.DataAccess.EntitiyFramework
{
    public class EfQuaryableRepositoryBase<TEntity> : IQueryableRepository<TEntity> where TEntity : class, IEntity, new()
    {


        private DbContext _context;
        private DbSet<TEntity> _entities;


        public EfQuaryableRepositoryBase(DbContext context)
        {
            _context = context;
        }


        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities==null)
                {
                    _entities = _context.Set<TEntity>();
                }
                return _entities; 
            }
            set
            {

            }
        }

        public IQueryable<TEntity> Table => this.Entities;

    }
}
