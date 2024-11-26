using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.DB.Interface;
using Entities.Entities;

namespace DataAccess.Interfaces
{
    public interface IProductsDal : IRepositoryService<Products>
    {
        List<Products> GetCategoryById(int categoryId, int skip, int take);
    }
}
