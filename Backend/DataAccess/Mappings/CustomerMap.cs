using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("Customer");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(p => p.CityId).Column("CityId").Not.LazyLoad();
            Map(p => p.NameSurname).Column("NameSurname");
            Map(p => p.PhoneNumber).Column("PhoneNumber");
            Map(p => p.Address).Column("Address");

        }
    }
}
