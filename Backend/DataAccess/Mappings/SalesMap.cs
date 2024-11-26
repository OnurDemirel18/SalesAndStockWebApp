using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class SalesMap : ClassMap<Sales>
    {
        public SalesMap()
        {
            Table("Sales");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(p => p.ProductId).Column("ProductId").Not.LazyLoad();
            References(p => p.CustomerId).Column("CustomerId").Not.LazyLoad();
            References(p => p.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            Map(p => p.Date).Column("Date");
            Map(p => p.Piece).Column("Piece");
        }
    }
}
