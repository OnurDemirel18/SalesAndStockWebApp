using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class CitiesMap : ClassMap<Cities>
    {
        public CitiesMap()
        {
            Table("Cities");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            Map(p => p.Name).Column("Name");
            Map(p => p.ParentId).Column("ParentId");
        }
    }
}
