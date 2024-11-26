using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Customer : IEntity
    {
        

		public virtual int Id { get; set; }
		public virtual string NameSurname { get; set; }
		public virtual string PhoneNumber { get; set; }
		public virtual string Address { get; set; }
		public virtual Cities CityId { get; set; }
    }
}
