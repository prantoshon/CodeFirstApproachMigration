using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using CodeFirstWebApp.Model.Model;
using CodeFirstWebApp.DatabaseContext.DatabaseContext;

namespace CodeFirstWebApp.Repository
{
  public  class CategoryRepositroy
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(CategoryModel categoryModel)
        {
         
          _dbContext.CategorysDbSet.Add(categoryModel);
           return _dbContext.SaveChanges() > 0;
        }
        //public bool Delete(int id)
        //{
        //    //Student aStudent = _dbContext.Students.FirstOrDefault((c => c.Id == id));
        //    //_dbContext.Students.Remove(aStudent);
        //    //return _dbContext.SaveChanges() > 0;
        //}
        //public bool Update(CategoryModel categoryModel)
        //{
        //    //Student aStudent = _dbContext.Students.FirstOrDefault(c => c.Id == student.Id);
        //    //if (aStudent != null)
        //    //{
        //    //    aStudent.RollNo = student.RollNo;
        //    //    aStudent.Name = student.Name;
        //    //    aStudent.Address = student.Address;
        //    //    aStudent.Age = student.Age;
        //    //}

        //    //return _dbContext.SaveChanges() > 0;
        //}

        //public List<CategoryModel> GetAll()
        //{

        //    //return _dbContext.Students.ToList();
        //}
        public CategoryModel GetById(int id)
        {

            return _dbContext.CategorysDbSet.FirstOrDefault((c => c.Id == id));
        }
    }
}
