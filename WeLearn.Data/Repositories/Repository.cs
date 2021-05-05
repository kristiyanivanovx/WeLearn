using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Repositories
{
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : SoftDeleteable
    {
        protected readonly ApplicationDbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T item)
        {
            await context.AddAsync(item);
        }

        public async Task AddAllAsync(IEnumerable<T> items)
        {
            await context.AddRangeAsync(items);
        }

        public async Task SoftDeleteAsync(int primaryKey)
        {
            var item = await GetByIdAsync(primaryKey);
            item.IsDeleted = true;
        }

        public virtual async Task<List<T>> Get<T2>(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().Where(x => !x.IsDeleted).ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Save(T item)
        {
            context.Update(item);
        }

        public void SaveAll(IEnumerable<T> items)
        {
            context.UpdateRange(items);
        }

        public async Task<IEnumerable<T>> GetAllWithDeletedAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
