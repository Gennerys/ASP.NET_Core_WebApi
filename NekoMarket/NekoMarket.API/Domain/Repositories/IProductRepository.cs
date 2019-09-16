using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NekoMarket.API.Domain.Models;

namespace NekoMarket.API.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();

    }
}
