using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NekoMarket.API.Domain.Repositories;
using NekoMarket.API.Persistence.Contexts;


namespace NekoMarket.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
