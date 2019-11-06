using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dg.KMS.People
{
    public class Person : Entity<long>
    {
        public virtual string Name { get; set; }
        public virtual DateTime CreationTime { get; set; }
        //public object Roles { get; set; }

        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }
}
