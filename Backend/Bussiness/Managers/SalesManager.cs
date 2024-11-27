using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Bussiness.Managers
{
    public class SalesManager : ISalesService
    {
        private ISalesDal _salesDal;

        public SalesManager(ISalesDal salesDal)
        {
            _salesDal = salesDal;
        }

        public Sales Add(Sales entity)
        {
            return _salesDal.Add(entity);
        }

        public void Delete(Sales entity)
        {
            _salesDal.Delete(entity);
        }

        public List<Sales> GetAll()
        {
            return _salesDal.GetList();
        }

        public Sales GetById(int id)
        {
            return _salesDal.Get(p => p.Id == id);
        }

        public List<Sales> Paging(int skip, int take)
        {
            return _salesDal.Paging(skip, take);
        }

        public Sales Update(Sales entity)
        {
            return _salesDal.Update(entity);
        }
    }
}
