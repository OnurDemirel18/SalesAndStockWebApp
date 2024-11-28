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

        Cities GetById(int id);
    }
}
