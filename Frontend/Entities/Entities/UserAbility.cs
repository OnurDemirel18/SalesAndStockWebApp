using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Entities
{
    public class UserAbility
    {
        public virtual int Id { get; set; }
        public virtual Ability AbilityId { get; set; }
        public virtual Employee EmployeeId { get; set; }
        public virtual string Password { get; set; }


    }
}
