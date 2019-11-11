using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstWebApp.Model.Model;
using CodeFirstWebApp.Bll.Manager;

namespace CodeFirstWebApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
      CategoryManager _categoryManager = new CategoryManager();
      CategoryModel categoryModel = new CategoryModel();
        [HttpGet]
      public ActionResult Add()
      {
          //CategoryModel categoryModel = new CategoryModel();

          return View(categoryModel);
      }

      [HttpPost]
      public ActionResult Add(CategoryModel categoryModel)
      {
          string message;
          if (_categoryManager.Add(categoryModel))
          {

              message = "Saved";
          }
          else
          {
              message = "Not Saved";
          }

          ViewBag.Message = message;
          return View(categoryModel);
      }

      public ActionResult GetById(int id)
      {
          //if (_categoryManager.GetById(id))
          //{
          //    categoryModel.Id = id;
          //}

          return View();
      }

    }
}