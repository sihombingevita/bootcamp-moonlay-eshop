using System;
using System.Collections.Generic;
using System.Text;

namespace Inventories.Data.Entities
{
    public interface IProduct
    {
        void Rename(string name);
        void AddStock(int stock);
        void Buy(int stock);
        void AssignTo(Category category);
    }
}
