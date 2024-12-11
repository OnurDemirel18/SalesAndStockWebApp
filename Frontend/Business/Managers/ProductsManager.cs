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
    public class ProductsManager : IProductsService
    {
        IDomainService _domainService;
        HttpClient _httpClient;

        public ProductsManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Products> Add(Products entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Products>(_domainService.Domain() + "api/products/add", entity);
            return await result.Content.ReadFromJsonAsync<Products>();
        }

        public void Delete(Products entity)
        {
            _httpClient.PostAsJsonAsync<Products>(_domainService.Domain()+ "api/products/delete",entity);
        }

        public async Task<List<Products>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Products>>(_domainService.Domain() + "api/products/getall");
            return result;
        }

        public async Task<Products> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Products>(_domainService.Domain() + "api/products/getbyid/" + id);
            return result;
        }

        public async Task<List<Products>> GetCategoryById(int categoryId, int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Products>>(_domainService.Domain() + "api/products/getcategorybyid/" + categoryId + "/" + skip + "/" + take);
            return result;
        }

        public async Task<Products> Update(Products entity)
        {
            var resut = await _httpClient.PostAsJsonAsync<Products>(_domainService.Domain() + "api/products/update", entity);
            return await resut.Content.ReadFromJsonAsync<Products>();
        }
    }
}
