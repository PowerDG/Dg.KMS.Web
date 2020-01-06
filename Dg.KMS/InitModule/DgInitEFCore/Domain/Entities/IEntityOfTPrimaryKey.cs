using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DgInitEFCore.Domain.Entities
{
    public interface IEntity : IEntity<int>
    {

    }
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TPrimaryKey Id { get; set; }

        /// <summary>
        /// Checks if this entity is transient (not persisted to database and it has not an <see cref="Id"/>).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>
        bool IsTransient();
    }
}
