using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.DB.Interface;
using Entities.Entities;

namespace DataAccess.Interfaces
{
    public interface IUserAbilityDal : IRepositoryService<UserAbility>
    {
        List<Employee> GetEmployeeByAbilityId(int abilityId, int skip, int take);
    }
}
