using System;
using System.Linq.Expressions;
using Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;

namespace Domain.Repositories
{
    public interface IBaseRepository<T> where T : IBase
    {
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate);       
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<int> DeactivateAsync(int id);
        Task<int> ActivateAsync(int id);
        Task<T> GetByNameAsync(string name);
    }
}

