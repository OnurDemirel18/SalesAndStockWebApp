using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface IStockService
    {
        Task<List<Stock>> Paging(int skip, int take);
        Task<List<Stock>> GetAll();
        Task<Stock> GetById(int id);
        Task<Stock> Add(Stock entity);
        Task<Stock> Update(Stock entity);
        void Delete(Stock entity);
    }
}
