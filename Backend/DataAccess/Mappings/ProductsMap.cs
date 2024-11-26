using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using FluentNHibernate.Mapping;

namespace DataAccess.Mappings
{
    public class ProductsMap : ClassMap<Products>
    {
        public ProductsMap()
        {
            Table("Products");
            Id(p => p.Id).Column("Id").GeneratedBy.Increment();
            References(p => p.CategoryId).Column("CategoryId").Not.LazyLoad();
            Map(p => p.Name).Column("Name");
            Map(p => p.Date).Column("Date");
            Map(p => p.Price).Column("Price");
        }
    }
}
