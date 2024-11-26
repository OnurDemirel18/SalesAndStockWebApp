using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface IUserAbilityService
    {
        List<Employee> GetEmployeeByAbilityId(int abilityId, int skip, int take);
        List<UserAbility> GetAll();
        UserAbility GetById(int id);
        UserAbility Add(UserAbility entity);
        UserAbility Update(UserAbility entity);
        void Delete(UserAbility entity);
    }
}
