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
    public class NHSalesDal : RepositoryManager<Sales>, ISalesDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NHSalesDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Sales> Paging(int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession())
            { 
                return session.Query<Sales>().OrderByDescending(p => p.Id).Skip(skip).Take(take).ToList();
            }
        }
    }
}
