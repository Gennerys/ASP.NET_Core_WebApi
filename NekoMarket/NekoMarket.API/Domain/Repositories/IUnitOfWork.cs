using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NekoMarket.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
