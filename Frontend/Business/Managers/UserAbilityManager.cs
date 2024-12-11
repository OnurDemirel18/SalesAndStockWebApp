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
    public class UserAbilityManager : IUserAbilityService
    {
        IDomainService _domainService;
        HttpClient _httpClient;

        public UserAbilityManager(IDomainService domainService, HttpClient httpClient)
        {
            _domainService = domainService;
            _httpClient = httpClient;
        }

        public async Task<UserAbility> Add(UserAbility entity)
        {
            var result = await _httpClient.PostAsJsonAsync<UserAbility>(_domainService.Domain() + "api/userability/add", entity);
            return await result.Content.ReadFromJsonAsync<UserAbility>();
        }

        public void Delete(UserAbility entity)
        {
            _httpClient.PostAsJsonAsync<UserAbility>(_domainService.Domain() + "api/userability/delete", entity);

        }

        public async Task<List<UserAbility>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<UserAbility>>(_domainService.Domain() + "api/userability/getall");
            return result;
        }

        public async Task<UserAbility> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<UserAbility>(_domainService.Domain() + "api/userability/getbyid/" + id);
            return result;
        }

        public async Task<List<Employee>> GetEmployeeByAbilityId(int abilityId, int skip, int take)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Employee>>(_domainService.Domain() + "api/userability/getemployeebyabilityid/" + abilityId + "/" + skip + "/" + take);
            return result;
        }

        public async Task<UserAbility> Update(UserAbility entity)
        {
            var result = await _httpClient.PostAsJsonAsync<UserAbility>(_domainService.Domain() + "api/userability/update", entity);
            return await result.Content.ReadFromJsonAsync<UserAbility>();
        }
    }
}
