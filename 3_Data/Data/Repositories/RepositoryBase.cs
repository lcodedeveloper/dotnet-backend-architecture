using Data.Repositories.Contexts;
using Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MainContext MainContext { get; set; }

        public RepositoryBase(MainContext context)
        {
            MainContext = context;
        }

        public IQueryable<T> FindAll()
        {
            return MainContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> predicate)
        {
            return MainContext.Set<T>().Where(predicate).AsNoTracking();
        }

        public void Create(T entity)
        {
            MainContext.Add(entity);
        }

        public void Delete(T entity)
        {
            MainContext.Set<T>().Remove(entity);

        }
        public void Update(T entity)
        {
            MainContext.Set<T>().Update(entity);
        }
    }
}
