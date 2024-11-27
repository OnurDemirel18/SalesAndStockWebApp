using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface ISalesService
    {
        List<Sales> GetAll();
        List<Sales> Paging(int skip, int take);
        Sales GetById(int id);
        Sales Add(Sales entity);
        Sales Update(Sales entity);
        void Delete(Sales entity);
    }
}
