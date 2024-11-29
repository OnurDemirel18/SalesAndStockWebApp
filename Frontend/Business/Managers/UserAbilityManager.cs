using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

using Entities.Entities;


namespace Business.Managers
{
    public class UserAbilityManager : IUserAbilityService
    {
        public Task<UserAbility> Add(UserAbility entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserAbility entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserAbility>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserAbility> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployeeByAbilityId(int abilityId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<UserAbility> Update(UserAbility entity)
        {
            throw new NotImplementedException();
        }
    }
}
