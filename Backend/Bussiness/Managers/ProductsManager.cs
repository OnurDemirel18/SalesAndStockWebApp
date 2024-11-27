using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Bussiness.Managers
{
    public class ProductsManager : IProductsService
    {
        private IProductsDal _productsDal;
        public ProductsManager(IProductsDal productsDal)
        {
            _productsDal = productsDal;
        }
        public Products Add(Products entity)
        {
            return _productsDal.Add(entity);
        }

        public void Delete(Products entity)
        {
            _productsDal.Delete(entity);
        }

        public List<Products> GetAll()
        {
            return _productsDal.GetList();
        }

        public Products GetById(int id)
        {
            return _productsDal.Get(p=> p.Id == id);
        }

        public List<Products> GetCategoryById(int categoryId, int skip, int take)
        {
            return _productsDal.GetCategoryById(categoryId, skip, take);
        }

        public Products Update(Products entity)
        {
            return _productsDal.Update(entity);
        }
    }
}
