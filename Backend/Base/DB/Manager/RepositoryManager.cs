using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Base.DB.Helper;
using Base.DB.Interface;
using Base.Entity;

namespace Base.DB.Manager
{
    public class RepositoryManager<T> : IRepositoryService<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        public RepositoryManager(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public T Add(T entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            { 
                session.Save(entity);
                session.Flush();
                return entity;
            }
        }

        public void Delete(T entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
                session.Clear();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
             
                return filter == null ? session.Query<T>().ToList() : session.Query<T>().Where(filter).ToList();
            }
        }

        public T Update(T entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                session.Flush();
                session.Clear();
                return entity;
            }
        }
    }
}
