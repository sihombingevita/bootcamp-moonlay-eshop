using Data.Entities;
using System.Collections.ObjectModel;
using System.Linq;

namespace Inventories.Data.Entities
{
    public class Product : Entity, IProduct
    {
        public string Name { get; set; }

        public string SKU { get; set; }

        public int Stock { get; set; }

        public virtual Collection<ProductCategory> ProductCategories { get; set; }

        public void AddStock(int stock)
        {
            this.Stock += stock;
        }

        public void AssignTo(Category category)
        {
            if(!this.ProductCategories.Any(o=>o.Category.Id == category.Id))
            {
                this.ProductCategories.Add(new ProductCategory { Product = this, Category = category });
            }
        }

        public void Buy(int stock)
        {
            var nStock = this.Stock - stock;
            if (nStock < 0)
                throw new System.Exception("Insufficient Stock");

            this.Stock = nStock;
        }

        public void Rename(string name)
        {
            this.Name = name;
        }
    }

    public class ProductCategory : Entity
    {
        public virtual Product Product { get; set; }

        public virtual Category Category { get; set; }
    }
}