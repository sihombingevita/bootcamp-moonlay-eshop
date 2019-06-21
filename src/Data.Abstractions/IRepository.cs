using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace Data.Abstractions
{
    public interface IRepository<TEntity> : IRepository
    {
        TEntity WithKey(int id);

        IEnumerable<TEntity> All(int page = 0, int size = 25);

        void Create(TEntity entity);

        void Edit(TEntity entity);

        void Delete(int id);

        void Delete(TEntity entity);
    }
}
