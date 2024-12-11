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
    public class CustomerManager : ICustomerService
    {
        IDomainService _domainService;
        HttpClient _httpClient;

        public CustomerManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Customer> Add(Customer entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Customer>(_domainService.Domain() + "api/customer/add", entity);
            return await result.Content.ReadFromJsonAsync<Customer>();
        }

        public void Delete(Customer entity)
        {
            _httpClient.PostAsJsonAsync<Customer>(_domainService.Domain() + "api/customer/delete", entity);
        }

        public async Task<List<Customer>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Customer>>(_domainService.Domain() + "api/customer/getall");
            return result;
        }

        public async Task<Customer> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Customer>(_domainService.Domain() + "api/xategory/getbyid/" + id);
            return result;
        }

        public async Task<List<Customer>> Paging(int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Customer>>(_domainService.Domain() + "api/customer/paging/" + skip + "/" + take);
            return result;
        }

        public async Task<Customer> Update(Customer entity)
        {
            var result =await _httpClient.PostAsJsonAsync<Customer>(_domainService.Domain() + "api/customer/update",entity);
            return await result.Content.ReadFromJsonAsync<Customer>();
        }
    }
}
