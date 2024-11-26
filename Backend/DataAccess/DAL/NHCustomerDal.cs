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

        public NHCustomerDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
