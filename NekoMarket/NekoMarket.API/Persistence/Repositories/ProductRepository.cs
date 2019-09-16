using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NekoMarket.API.Domain.Models;
using NekoMarket.API.Domain.Repositories;
using NekoMarket.API.Persistence.Contexts;


namespace NekoMarket.API.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

       
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                .ToListAsync();
        }
    }
}
