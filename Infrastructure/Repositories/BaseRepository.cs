using HrELP.Domain.Entities.Abstract;
using HrELP.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HrELP.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly HrElpContext _context;
        protected DbSet<T> _table;

        public BaseRepository(HrElpContext context)
        {
            _context = context;
            _table = context.Set<T>();

        }
        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            await _context.SaveChangesAsync();
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
    }
}
