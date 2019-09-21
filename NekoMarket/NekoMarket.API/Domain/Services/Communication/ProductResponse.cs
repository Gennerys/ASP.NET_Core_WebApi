using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NekoMarket.API.Domain.Models;

namespace NekoMarket.API.Domain.Services.Communication
{
    public class ProductResponse : BaseResponse<Product>
    {
        public ProductResponse(Product product) : base(product)
        {

        }
        public ProductResponse(string message) : base(message)
        {

        }
    }
}
