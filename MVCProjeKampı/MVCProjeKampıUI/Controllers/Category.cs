using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjeKampıUI.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager();
        public IActionResult Index()
        {
            var categoryvalues = cm.GetAllBL();
            return View(categoryvalues);
        }
       
    }
}
