using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : SoftDeleteable
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllWithDeletedAsync();

        Task<List<T>> Get<T2>(Expression<Func<T, bool>> predicate);

        Task<T> GetByIdAsync(int id);

        void Save(T item);

        Task AddAsync(T item);

        void SaveAll(IEnumerable<T> items);

        Task AddAllAsync(IEnumerable<T> items);

        Task SoftDeleteAsync(int primaryKey);
    }
}
