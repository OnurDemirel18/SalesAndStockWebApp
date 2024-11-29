using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

using Entities.Entities;

namespace Business.Managers
{
    public class ProductsManager : IProductsService
    {
        public Task<Products> Add(Products entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Products entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Products>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Products>> GetCategoryById(int categoryId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Products> Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
