using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.DB.Helper;
using Base.DB.Manager;
using DataAccess.Interfaces;
using Entities.Entities;

namespace DataAccess.DAL
{
    public class NHUserAbilityDal : RepositoryManager<UserAbility>, IUserAbilityDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NHUserAbilityDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Employee> GetEmployeeByAbilityId(int abilityId, int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession()) 
            
            {
                var result = session.Query<UserAbility>().Where(p => p.AbilityId.Id == abilityId)
                    .Select(p => p.EmployeeId).Skip(skip).Take(take).ToList();

                return result;
            }
        }
    }
}
