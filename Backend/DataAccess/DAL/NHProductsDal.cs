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
    public class NHProductsDal : RepositoryManager<Products>, IProductsDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NHProductsDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Products> GetCategoryById(int categoryId, int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = session.Query<Products>().Where(p => p.CategoryId.Id == categoryId)
                    .OrderBy(p => p.Name)
                    .Skip(skip).Take(take).ToList();
                return result;
            }
        }
    }
}
