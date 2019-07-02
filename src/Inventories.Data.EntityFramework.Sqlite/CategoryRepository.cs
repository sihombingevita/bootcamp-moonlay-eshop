using Data.EntityFramework.Sqlite;
using Inventories.Abstractions;
using Inventories.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventories.Data.EntityFramework.Sqlite
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

    }
}
