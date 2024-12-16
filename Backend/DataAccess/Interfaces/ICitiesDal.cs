using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.DB.Interface;
using Entities.Entities;

namespace DataAccess.Interfaces
{
    public interface ICitiesDal : IRepositoryService<Cities>
    {
        List<Cities> ParentById(int parentId, int skip, int take);

        void MultipleDelete(List<Cities> cities);

        List<Cities> Cities(int skip, int take);

        bool IsThereLowerCities(int parentId);
    }
}
