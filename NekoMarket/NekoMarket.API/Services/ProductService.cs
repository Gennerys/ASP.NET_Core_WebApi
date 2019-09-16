using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NekoMarket.API.Domain.Models;
using NekoMarket.API.Domain.Repositories;
using NekoMarket.API.Domain.Services;


namespace NekoMarket.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
