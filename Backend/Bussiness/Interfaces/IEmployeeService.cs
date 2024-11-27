using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee Add(Employee entity);
        Employee Update(Employee entity);
        void Delete(Employee entity);
    }
}
