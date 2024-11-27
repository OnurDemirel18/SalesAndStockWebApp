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
    public class NHStockDal : RepositoryManager<Stock>, IStockDal
    {
        private NHibernateHelper _nhibernateHelper;
        public NHStockDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper = nHibernateHelper;
        }

        public List<Stock> Paging(int skip, int take)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                return session.Query<Stock>().OrderByDescending(p => p.Date).Skip(skip).Take(take).ToList();
            }
        }
    }
}
