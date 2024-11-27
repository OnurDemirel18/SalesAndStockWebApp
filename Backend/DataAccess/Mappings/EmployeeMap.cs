using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("Employee");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.NameSurname).Column("NameSurname");
            Map(p => p.Address).Column("Address");
            Map(p => p.Email).Column("Email");
            Map(p => p.PhoneNumber).Column("PhoneNumber");
        }
    }
}
