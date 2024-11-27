using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface IAbilityService
    {
        List<Ability> GetAll();
        Ability GetById(int id);
        Ability Add(Ability entity);
        Ability Update(Ability entity);
        void Delete(Ability entity);
    }
}
