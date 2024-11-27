using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> Paging(int skip, int take);
        List<Customer> GetAll();
        Customer GetById(int id);
        Customer Add(Customer entity);
        Customer Update(Customer entity);
        void Delete(Customer entity);
    }
}
