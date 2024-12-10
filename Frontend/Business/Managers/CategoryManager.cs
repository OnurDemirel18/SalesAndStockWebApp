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
    public class CategoryManager : ICategoryService
    {
        private IDomainService _domainService;
        private HttpClient _httpClient;

        public CategoryManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Category> Add(Category entity)
        {
            var domain = _domainService.Domain();
            var result = await _httpClient.PostAsJsonAsync<Category>(_domainService.Domain() + "/api/category/add", entity);
            return await result.Content.ReadFromJsonAsync<Category>();
        }

        public void Delete(Category entity)
        {
            _httpClient.PostAsJsonAsync<Category>(_domainService.Domain() + "/api/cotegory/delete", entity);
        }

        public async Task<List<Category>> GetAll()
        {
            var domain = _domainService.Domain();
            var result = await _httpClient.GetFromJsonAsync<List<Category>>(_domainService.Domain()+"/api/category/getall");
            return result;
        }

        public async Task<Category> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Category>(_domainService.Domain() + "api/category/getbyid/"+ id);
            return result;
        }

        public async Task<List<Category>> Paging(int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Category>>(_domainService.Domain() + "api/category/paging/"+ skip+"/" + take);
            return result;
        }

        public async Task<Category> Update(Category entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Category>(_domainService.Domain() + "/api/cotegory/update", entity);
            return await result.Content.ReadFromJsonAsync<Category>();
        }
    }
}
