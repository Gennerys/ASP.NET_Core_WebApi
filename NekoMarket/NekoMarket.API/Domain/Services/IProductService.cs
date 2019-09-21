using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NekoMarket.API.Domain.Models;
using NekoMarket.API.Domain.Models.Queries;
using NekoMarket.API.Domain.Services.Communication;


namespace NekoMarket.API.Domain.Services
{
    public interface IProductService
    {

        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);

    }
}
