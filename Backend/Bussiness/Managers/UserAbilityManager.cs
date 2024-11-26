using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using FluentNHibernate.Data;

namespace Bussiness.Managers
{
    public class UserAbilityManager : IUserAbilityService
    {
        private IUserAbilityDal _userAbilityDal;

        public UserAbilityManager(IUserAbilityDal userAbilityDal)
        {
            _userAbilityDal = userAbilityDal;            
        }
        public UserAbility Add(UserAbility entity)
        {
            return _userAbilityDal.Add(entity);
        }

        public void Delete(UserAbility entity)
        {
            _userAbilityDal.Delete(entity);
        }

        public List<UserAbility> GetAll()
        {
            return _userAbilityDal.GetList();
        }

        public UserAbility GetById(int id)
        {
            return _userAbilityDal.Get(p => p.Id == id);
        }

        public List<Employee> GetEmployeeByAbilityId(int abilityId, int skip, int take)
        {
            return _userAbilityDal.GetEmployeeByAbilityId(abilityId, skip, take);
        }

        public UserAbility Update(UserAbility entity)
        {
            return _userAbilityDal.Update(entity);
        }
    }
}
