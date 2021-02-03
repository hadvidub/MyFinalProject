using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category categoryt);
        void Delete(Category category);

        List<Category> GetAllByCategory(int categoryId);

    }
}
