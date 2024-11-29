using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface IAbilityService
    {
        Task<List<Ability>> GetAll();
        Task<Ability> GetById(int id);
        Task<Ability> Add(Ability entity);
        Task<Ability> Update(Ability entity);
        void Delete(Ability entity);
    }
}
