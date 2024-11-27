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
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public Employee Add(Employee entity)
        {
            return _employeeDal.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _employeeDal.Delete(entity);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(p => p.Id == id);
        }

        public Employee Update(Employee entity)
        {
            return _employeeDal.Update(entity);
        }
    }
}
