using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface ICitiesService
    {
        List<Cities> ParentById(int parentId, int skip, int take);
        void MultipleDelete(List<Cities> cities);
        Cities Add(Cities entity);
        Cities Update(Cities entity);
        void Delete(Cities entity);
        bool IsThereLowerCities(int parentId);
        Cities GetById(int id);
        List<Cities> Cities(int skip, int take);
    }
}
