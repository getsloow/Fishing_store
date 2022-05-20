
using Microsoft.EntityFrameworkCore;
using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Repositories.Interfaces;
using System.Linq.Expressions;

namespace WhatsArt.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        public ApplicationDbContext dbContext { get; set; }

        public RepositoryBase(ApplicationDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.dbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
        }
    }
}