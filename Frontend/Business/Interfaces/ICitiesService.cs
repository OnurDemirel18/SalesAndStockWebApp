using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface ICitiesService
    {
        Task<List<Cities>> ParentById(int parentId, int skip, int take);
        Task<List<Cities>> Cities(int skip, int take);
        void MultipleDelete(List<Cities> cities);
        Task<Cities> Add(Cities entity);
        Task<Cities> Update(Cities entity);
        void Delete(Cities entity);

        Task<Cities> GetById(int id);
    }
}
