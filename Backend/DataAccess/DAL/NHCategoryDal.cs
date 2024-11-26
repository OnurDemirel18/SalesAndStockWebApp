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
    public class NHCategoryDal : RepositoryManager<Category>, ICategoryDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NHCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Category> Paging(int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession()) 
            {
                return session.Query<Category>().OrderBy(p => p.Name).Skip(skip).Take(take).ToList();


            }
        }
    }
}
