using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<List<Category>> Paging(int skip, int take);

        Task<Category> GetById(int id);
        Task<Category> Add(Category entity);
        Task<Category> Update(Category entity);
        void Delete(Category entity);
    }
}
