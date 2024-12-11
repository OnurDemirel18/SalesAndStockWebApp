using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Configurations;
using Entities.Entities;

namespace Business.Managers
{
    public class EmployeeManager : IEmployeeService
    {
        IDomainService _domainService;
        HttpClient _httpClient;

        public EmployeeManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Employee> Add(Employee entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Employee>(_domainService.Domain() + "api/employee/add", entity);
            return await result.Content.ReadFromJsonAsync<Employee>();
        }

        public void Delete(Employee entity)
        {
            _httpClient.PostAsJsonAsync<Employee>(_domainService.Domain() + "api/employee/delete", entity);
        }

        public async Task<List<Employee>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Employee>>(_domainService.Domain() + "api/employee/getall");
            return result;
        }

        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>(_domainService.Domain() + "api/employee/getbyid/" + id);
            return result;
        }

        public async Task<Employee> Update(Employee entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Employee>(_domainService.Domain() + "api/employee/update",entity);
            return await result.Content.ReadFromJsonAsync<Employee>();
        }
    }
}
