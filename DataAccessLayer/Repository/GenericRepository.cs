using DataAccessLayer.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Models.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _context;

        private DbSet<T> table;

        public GenericRepository(ApplicationContext _context)
        {

            this._context = _context;
            table = _context.Set<T>();

        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }
        public async Task<T> GetById(object id)
        {

            var Data = await table.FindAsync(id);
            if (Data == null)
            {
                return null;
            }
            return Data;
        }
        public async Task Insert(T obj)
        {

            await table.AddAsync(obj);
            await _context.SaveChangesAsync();

        }
        public async Task Update(T obj)
        {
            table.Attach(obj);

            _context.Entry(obj).State = EntityState.Modified;
          await  Save();
        }
        public async Task Delete(object id)
        {

            T existing = await table.FindAsync(id);

            table.Remove(existing);

            await _context.SaveChangesAsync();
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
