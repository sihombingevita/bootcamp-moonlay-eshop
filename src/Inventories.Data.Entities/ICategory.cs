using System;
using System.Collections.Generic;
using System.Text;

namespace Inventories.Data.Entities
{
    public interface ICategory
    {
        void AddProduct(IEnumerable<Product> products);
    }
}
