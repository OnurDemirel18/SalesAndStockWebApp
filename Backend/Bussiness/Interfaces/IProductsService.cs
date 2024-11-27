using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface IProductsService
    {
        List<Products> GetCategoryById(int categoryId, int skip, int take);
        List<Products> GetAll();
        Products GetById(int id);
        Products Add(Products entity);
        Products Update(Products entity);
        void Delete(Products entity);
    }
}
