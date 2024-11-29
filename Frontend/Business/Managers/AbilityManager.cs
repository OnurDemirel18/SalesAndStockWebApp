using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class AbilityManager : IAbilityService
    {
        public Task<Ability> Add(Ability entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ability entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ability>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Ability> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ability> Update(Ability entity)
        {
            throw new NotImplementedException();
        }
    }
}
