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
    public class NHCustomerDal : RepositoryManager<Customer>, ICustomerDal
    {
        private NHibernateHelper _nHibernateHelper;

        public NHCustomerDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Customer> Paging(int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession()) 
            {
                return session.Query<Customer>().OrderBy(p => p.NameSurname).Skip(skip).Take(take).ToList();
            }
        }
    }
}
