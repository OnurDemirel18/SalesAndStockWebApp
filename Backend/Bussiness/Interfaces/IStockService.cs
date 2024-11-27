using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface IStockService
    {
        List<Stock> Paging(int skip, int take);
        List<Stock> GetAll();
        Stock GetById(int id);
        Stock Add(Stock entity);
        Stock Update(Stock entity);
        void Delete(Stock entity);
    }
}
