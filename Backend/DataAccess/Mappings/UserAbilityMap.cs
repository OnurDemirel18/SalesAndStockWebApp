using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class UserAbilityMap : ClassMap<UserAbility>
    {
        public UserAbilityMap() {
            Table("UserAbility");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Password).Column("Password");
            References(p => p.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(p => p.AbilityId).Column("AbilityId").Not.LazyLoad();
        }
    }
}
