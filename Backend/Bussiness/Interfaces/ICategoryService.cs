using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Bussiness.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> Paging(int skip, int take);

        Category GetById(int id);
        Category Add(Category entity);
        Category Update(Category entity);
        void Delete(Category entity);
    }
}
