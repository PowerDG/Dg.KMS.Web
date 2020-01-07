
using DgInitEFCore.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DgInitEFCore.Domain.Entities
{

    /// <summary>
    /// 泛型实体基类
    /// </summary>
    /// <typeparam name="TPrimaryKey">主键类型</typeparam>

    /// <summary>
    /// 定义默认主键类型为int的实体基类
    /// </summary>
    public abstract class Entity : Entity<int>
    {

    }


    [Serializable]
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        public virtual TPrimaryKey Id { get; set; }

        /// <summary>
        /// Checks if this entity is transient (it has not an Id).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>
        public virtual bool IsTransient()
        {
            if (EqualityComparer<TPrimaryKey>.Default.Equals(Id, default(TPrimaryKey)))
            {
                return true;
            }

            //Workaround for EF Core since it sets int/long to min value when attaching to dbcontext
            if (typeof(TPrimaryKey) == typeof(int))
            {
                return Convert.ToInt32(Id) <= 0;
            }

            if (typeof(TPrimaryKey) == typeof(long))
            {
                return Convert.ToInt64(Id) <= 0;
            }

            return false;
        }

        /// <inheritdoc/>
        public virtual bool EntityEquals(object obj)
        {
            if (obj == null || !(obj is Entity<TPrimaryKey>))
            {
                return false;
            }

            //Same instances must be considered as equal
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            //Transient objects are not considered as equal
            var other = (Entity<TPrimaryKey>)obj;
            if (IsTransient() && other.IsTransient())
            {
                return false;
            }

            //Must have a IS-A relation of types or must be same type
            var typeOfThis = GetType();
            var typeOfOther = other.GetType();
            if (!typeOfThis.GetTypeInfo().IsAssignableFrom(typeOfOther) && !typeOfOther.GetTypeInfo().IsAssignableFrom(typeOfThis))
            {
                return false;
            }

            if (this is IMayHaveTenant && other is IMayHaveTenant &&
                this.As<IMayHaveTenant>().TenantId != other.As<IMayHaveTenant>().TenantId)
            {
                return false;
            }

            if (this is IMustHaveTenant && other is IMustHaveTenant &&
                this.As<IMustHaveTenant>().TenantId != other.As<IMustHaveTenant>().TenantId)
            {
                return false;
            }

            return Id.Equals(other.Id);
        }

        public override string ToString()
        {
            return $"[{GetType().Name} {Id}]";
        }
    }

    
}