using Data.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Inventories.Data.Entities
{
    public class Category : Entity, ICategory
    {
        public string Name { get; set; }

        public virtual Collection<ProductCategory> ProductCategories { get; set; }

        public void AddProduct(IEnumerable<Product> products)
        {
            var productIds = products.Select(o => o.Id);

            var existingProducts = this.ProductCategories.Where(o => o.Category.Id == this.Id).Select(o => o.Product);

            var notExistsProducts = products.Except(existingProducts);

            foreach (var product in notExistsProducts)
                this.ProductCategories.Add(new ProductCategory { Category = this, Product = product });
        }
    }
}