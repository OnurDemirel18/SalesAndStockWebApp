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
    public class CitiesManager : ICitiesService
    {
        private IDomainService _domainService;
        private HttpClient _httpClient;

        public CitiesManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Cities> Add(Cities entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Cities>(_domainService.Domain() + "api/cities/add", entity);
            return await result.Content.ReadFromJsonAsync<Cities>();

        }

        public async Task<List<Cities>> Cities(int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Cities>>(_domainService.Domain() + "api/cities/cities/"+ skip + "/" + take);
            return result;
        }

        public void Delete(Cities entity)
        {
            _httpClient.PostAsJsonAsync<Cities>(_domainService.Domain() + "api/cities/delete", entity);
        }

        public async Task<Cities> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Cities>(_domainService.Domain() +"api/cities/getbyid/"+ id);
            return result;
        }

        public void MultipleDelete(List<Cities> cities)
        {
            _httpClient.PostAsJsonAsync<List<Cities>>(_domainService.Domain() + "api/cities/multipledelete", cities);
        }

        public async Task<List<Cities>> ParentById(int parentId, int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Cities>>(_domainService.Domain() + "api/cities/parentbyid/" + parentId + "/" + skip + "/" + take);
            return result;
        }

        public async Task<Cities> Update(Cities entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Cities>(_domainService.Domain() + "api/cities/update", entity);
            return await result.Content.ReadFromJsonAsync<Cities>();
        }
    }
}
