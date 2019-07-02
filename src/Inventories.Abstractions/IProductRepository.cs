using Data.Abstractions;
using ExtCore.Data.Abstractions;
using Inventories.Data.Entities;
using System;

namespace Inventories.Abstractions
{
    public interface IProductRepository : IRepository<Product>
    {
        
    }
}
