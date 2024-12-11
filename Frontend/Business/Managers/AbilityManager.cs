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
    public class AbilityManager : IAbilityService
    {
        private IDomainService _domainService;
        private HttpClient _httpClient;

        public AbilityManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<Ability> Add(Ability entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Ability>(_domainService.Domain() + "api/ability/add", entity);
            return await result.Content.ReadFromJsonAsync<Ability>();
        }

        public void Delete(Ability entity)
        {
            _httpClient.PostAsJsonAsync<Ability>(_domainService.Domain() + "api/ability/delete" , entity);
        }

        public async Task<List<Ability>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Ability>>(_domainService.Domain() + "/api/ability/getall");
            return result;
        }

        public async Task<Ability> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Ability>(_domainService.Domain() + "/api/ability/getbyid/" + id);
            return result;
        }

        public async Task<Ability> Update(Ability entity)
        {
            var result = await _httpClient.PostAsJsonAsync<Ability>(_domainService.Domain() + "/api/ability/update", entity);
            return await result.Content.ReadFromJsonAsync<Ability>();
        }
    }
}
