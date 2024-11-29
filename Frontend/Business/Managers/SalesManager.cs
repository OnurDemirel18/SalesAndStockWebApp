using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

using Entities.Entities;

namespace Business.Managers
{
    public class SalesManager : ISalesService
    {
        public Task<Sales> Add(Sales entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sales entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sales>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Sales> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sales>> Paging(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Sales> Update(Sales entity)
        {
            throw new NotImplementedException();
        }
    }
}
