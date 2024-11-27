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
    public class AbilityManager : IAbilityService
    {
        private IAbilityDal _abilityDal;
        public AbilityManager(IAbilityDal abilityDal)
        {
            _abilityDal = abilityDal;
        }

        public Ability Add(Ability entity)
        {
            return _abilityDal.Add(entity);
        }

        public void Delete(Ability entity)
        {
            _abilityDal.Delete(entity);
        }

        public List<Ability> GetAll()
        {
            return _abilityDal.GetList().OrderByDescending(p =>p.Id).ToList();
        }

        public Ability GetById(int id)
        {
            return _abilityDal.Get(p=> p.Id == id);
        }

        public Ability Update(Ability entity)
        {
            return _abilityDal.Update(entity);
        }
    }
}
