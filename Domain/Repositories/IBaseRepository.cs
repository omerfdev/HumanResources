using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Domain.Repositories
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        Task AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        

    }
}

