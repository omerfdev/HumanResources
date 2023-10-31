
using Domain.Entities.Abstract;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HrELP.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBase
    {
        private readonly Context _context;
        protected DbSet<T> _table;

        public BaseRepository(Context context)
        {
            _context = context;
            _table = context.Set<T>();

        }
       
        public async Task<int> AddAsync(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Added;
            entity.ModifiedTime = DateTime.Now;
            await _table.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Deleted;
            entity.IsActive = false;
            _table.Remove(entity);
           return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.FirstOrDefaultAsync(predicate);
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.Where(predicate).ToListAsync();
        }
        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _table.AsQueryable();
            // Include işlemleri
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            var result = await query.Where(predicate).ToListAsync();
            return result;
        }

        public async Task<int> DeactivateAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                entity.ModifiedTime = DateTime.Now;
                entity.IsActive = false;              
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ActivateAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                entity.ModifiedTime = DateTime.Now;
                entity.IsActive = true;               
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<T> GetByNameAsync(string name)
        {
            return await _table.FindAsync(name);
        }
    }
}
