using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Bussiness.Managers
{
    public class CitiesManager : ICitiesService
    {
        ICitiesDal _citiesDal;

        public CitiesManager(ICitiesDal citiesDal)
        {
            _citiesDal = citiesDal;
        }

        public Cities Add(Cities entity)
        {
            return _citiesDal.Add(entity);
        }

        public void Delete(Cities entity)
        {
            _citiesDal.Delete(entity);
        }

        public Cities GetById(int id)
        {
            return _citiesDal.Get(p => p.Id == id);
        }

        public void MultipleDelete(List<Cities> cities)
        {
            _citiesDal.MultipleDelete(cities);
        }

        public List<Cities> ParentById(int parentId, int skip, int take)
        {
            return _citiesDal.ParentById(parentId, skip, take);
        }

        public Cities Update(Cities entity)
        {
            return _citiesDal.Update(entity);
        }
    }
}
