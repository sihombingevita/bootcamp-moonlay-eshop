using ExtCore.Data.Entities.Abstractions;
using System.Collections.ObjectModel;

namespace Inventories.Data.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Collection<ProductCategory> ProductCategories { get; set; }
    }
}