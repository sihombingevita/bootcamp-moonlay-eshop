using Data.EntityFramework.Sqlite;
using Inventories.Abstractions;
using Inventories.Data.Entities;

namespace Inventories.Data.EntityFramework.Sqlite
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
    }
}
