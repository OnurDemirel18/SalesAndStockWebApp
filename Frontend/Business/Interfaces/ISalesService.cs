using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface ISalesService
    {
        Task<List<Sales>> GetAll();
        Task<List<Sales>> Paging(int skip, int take);
        Task<Sales> GetById(int id);
        Task<Sales> Add(Sales entity);
        Task<Sales> Update(Sales entity);
        void Delete(Sales entity);
    }
}
