using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> Paging(int skip, int take);
        Task<List<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<Customer> Add(Customer entity);
        Task<Customer> Update(Customer entity);
        void Delete(Customer entity);
    }
}
