using ExtCore.Data.Entities.Abstractions;
using System.Collections.ObjectModel;

namespace Inventories.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SKU { get; set; }

        public int Stock { get; set; }

        public virtual Collection<ProductCategory> ProductCategories { get; set; }
    }

    public class ProductCategory : IEntity
    {
        public int Id { get; set; }

        public virtual Product Product { get; set; }

        public virtual Category Category { get; set; }
    }
}