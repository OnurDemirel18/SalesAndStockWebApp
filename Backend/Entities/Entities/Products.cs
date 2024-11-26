using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Entity;

namespace Entities.Entities
{
    public class Products : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Category CategoryId { get; set; }
        public virtual DateTime Date {  get; set; }
        public virtual decimal Price { get; set; }

    }
}
