using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Entity;

namespace Entities.Entities
{
    public class Cities : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int ParentId { get; set; }
    }
}
