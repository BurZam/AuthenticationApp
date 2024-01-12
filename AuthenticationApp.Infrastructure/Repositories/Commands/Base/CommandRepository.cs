using AuthenticationApp.Core.Interfaces.Base;
using AuthenticationApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationApp.Infrastructure.Repositories.Commands.Base
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        protected readonly DataContext _context;

        public CommandRepository(DataContext _context)
        {
            this._context = _context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await this._context.Set<T>().AddAsync(entity);
            await this._context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            this._context.Entry(entity).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this._context.Set<T>().Remove(entity);
            await this._context.SaveChangesAsync();
        }
    }
}
