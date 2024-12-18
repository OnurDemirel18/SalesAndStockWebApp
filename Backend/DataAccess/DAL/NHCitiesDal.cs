﻿using System;
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
    public class NHCitiesDal : RepositoryManager<Cities>, ICitiesDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NHCitiesDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        

        public void MultipleDelete(List<Cities> cities)
        {
            using(var session = _nHibernateHelper.OpenSession()) 
            {
                foreach (var c in cities)
                {
                    session.Delete(c);
                }
                session.Flush();
                session.Clear();
            }
        }

        public List<Cities> ParentById(int parentId, int skip, int take)
        {
            using(var session = _nHibernateHelper.OpenSession())
            {
                var result = session.Query<Cities>().Where(p => p.ParentId == parentId).OrderBy(p =>p.Name)
                    .Skip(skip).Take(take).ToList();
                return result;
            }
        }

        public List<Cities> Cities(int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = session.Query<Cities>().Where(p => p.ParentId == 0).OrderBy(p => p.Name)
                    .Skip(skip).Take(take).ToList();
                return result;
            }
        }

        public bool IsThereLowerCities(int parentId)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = session.Query<Cities>().Where(p => p.ParentId == parentId).Count();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}
