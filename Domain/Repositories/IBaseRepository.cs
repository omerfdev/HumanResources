using System;
using System.Linq.Expressions;
using Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;

namespace Domain.Repositories
{
    public interface IBaseRepository<T> where T : IBase
    {
        Task AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();

    }
}

