using ExtCore.Data.Entities.Abstractions;
using System;

namespace Data.Entities
{
    public class Entity : IEntity
    {
        public int Id { get; set; }

        public DateTimeOffset Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
