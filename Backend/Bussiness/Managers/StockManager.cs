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
    public class StockManager : IStockService
    {
        private IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public Stock Add(Stock entity)
        {
            return _stockDal.Add(entity);
        }

        public void Delete(Stock entity)
        {
            _stockDal.Delete(entity);
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetList();
        }

        public Stock GetById(int id)
        {
            return _stockDal.Get(p => p.Id == id);
        }

        public List<Stock> Paging(int skip, int take)
        {
            return _stockDal.Paging(skip, take);
        }

        public Stock Update(Stock entity)
        {
            return _stockDal.Update(entity);
        }
    }
}
