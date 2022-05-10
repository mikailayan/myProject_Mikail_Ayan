using BusinessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVCProjeKampıUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public IActionResult Index()
        {
            var categoryvalues = cm.GetAllBL();
            return View(categoryvalues);
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            cm.CategoryAddBL(category);
            return RedirectToAction("Index");
        }
       
    }
}
