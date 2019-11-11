using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstWebApp.Model.Model;
using CodeFirstWebApp.Repository;

namespace CodeFirstWebApp.Bll.Manager
{
   public class CategoryManager
    {
        CategoryRepositroy _categoryRepositroy = new CategoryRepositroy();

        public bool Add(CategoryModel categoryModel)
        {
            return _categoryRepositroy.Add(categoryModel);
        }

        public CategoryModel GetById(int id)
        {
            return _categoryRepositroy.GetById(id);
        }
    }
}
