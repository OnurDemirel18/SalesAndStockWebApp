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
    
    public class StockManager : IStockService
    {
        private IDomainService _domainService;
        private HttpClient _httpClient;

        public StockManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Stock> Add(Stock entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Stock>(_domainService.Domain() + "api/stock/add", entity);
            return await result.Content.ReadFromJsonAsync<Stock>();
        }

        public void Delete(Stock entity)
        {
            _httpClient.PostAsJsonAsync<Stock>(_domainService.Domain()+"api/stock/delete" , entity);

        }

        public async Task<List<Stock>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Stock>>(_domainService.Domain() + "api/stock/getall");
            return result;
        }

        public async Task<Stock> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Stock>(_domainService.Domain() + "api/stock/getbyid/" + id);
            return result;
        }

        public async Task<List<Stock>> Paging(int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Stock>>(_domainService.Domain() + "api/stock/paging/" + skip + "/" + take);
            return result;
        }

        public async Task<Stock> Update(Stock entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Stock>(_domainService.Domain() + "api/stock/update", entity);
            return await result.Content.ReadFromJsonAsync<Stock>();
        }
    }
}
