using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface IUserAbilityService
    {
        Task<List<Employee>> GetEmployeeByAbilityId(int abilityId, int skip, int take);
        Task<List<UserAbility>> GetAll();
        Task<UserAbility> GetById(int id);
        Task<UserAbility> Add(UserAbility entity);
        Task<UserAbility> Update(UserAbility entity);
        void Delete(UserAbility entity);
    }
}
