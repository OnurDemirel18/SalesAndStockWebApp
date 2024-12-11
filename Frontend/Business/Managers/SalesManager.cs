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
    public class SalesManager : ISalesService
    {
        private IDomainService _domainService;
        private HttpClient _httpClient;

        public SalesManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Sales> Add(Sales entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Sales>(_domainService.Domain() + "api/sales/add", entity);
            return await result.Content.ReadFromJsonAsync<Sales>();
        }

        public void Delete(Sales entity)
        {
            _httpClient.PostAsJsonAsync<Sales>(_domainService.Domain() + "api/sales/delete",entity);

        }

        public async Task<List<Sales>> GetAll()
        {
            var result =await _httpClient.GetFromJsonAsync<List<Sales>>(_domainService.Domain() + "api/sales/getall");
            return result;
        }

        public async Task<Sales> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Sales>(_domainService.Domain() + "api/sales/getbyid/" + id);
            return result;
        }

        public async Task<List<Sales>> Paging(int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Sales>>(_domainService.Domain() + "api/sales/paging/" + skip + "/" + take);
            return result;
        }

        public async Task<Sales> Update(Sales entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Sales>(_domainService.Domain() + "api/sales/update", entity);
            return await result.Content.ReadFromJsonAsync<Sales>();
        }
    }
}
