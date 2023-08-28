using DataAccessLayer.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Models.DbContext;
using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _table;

        public GenericRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _table.FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await _table.AddAsync(entity);
            await SaveAsync();
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteAsync(object id)
        {
            T entity = await _table.FindAsync(id);
            if (entity != null)
            {
                _table.Remove(entity);
                await SaveAsync();
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetAllUsersLeave(Guid Id)
        {

            var leaveUser= await _context.LeaveRequests.Where(x=>x.Id==Id).ToListAsync();
            return leaveUser;
        }

    }
}
