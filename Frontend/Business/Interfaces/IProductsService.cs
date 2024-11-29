using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Business.Interfaces
{
    public interface IProductsService
    {
        Task<List<Products>> GetCategoryById(int categoryId, int skip, int take);
        Task<List<Products>> GetAll();
        Task<Products> GetById(int id);
        Task<Products> Add(Products entity);
        Task<Products> Update(Products entity);
        void Delete(Products entity);
    }
}
