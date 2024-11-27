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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public Customer Add(Customer entity)
        {
            return _customerDal.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _customerDal?.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(p => p.Id == id);
        }

        public List<Customer> Paging(int skip, int take)
        {
            return _customerDal.Paging(skip, take);
        }

        public Customer Update(Customer entity)
        {
            return _customerDal.Update(entity);
        }
    }
}
