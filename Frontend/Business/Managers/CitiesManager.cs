using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

using Entities.Entities;

namespace Business.Managers
{
    public class CitiesManager : ICitiesService
    {
        public Task<Cities> Add(Cities entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cities entity)
        {
            throw new NotImplementedException();
        }

        public Task<Cities> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void MultipleDelete(List<Cities> cities)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cities>> ParentById(int parentId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Cities> Update(Cities entity)
        {
            throw new NotImplementedException();
        }
    }
}
