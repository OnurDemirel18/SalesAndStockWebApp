using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

using Entities.Entities;

namespace Business.Managers
{
    public class StockManager : IStockService
    {
        public Task<Stock> Add(Stock entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Stock entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Stock>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Stock> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Stock>> Paging(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Stock> Update(Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
