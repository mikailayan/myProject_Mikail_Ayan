using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TekrarBusinessLayer.Abstract;
using TekrarUI.Models;

namespace TekrarUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            
            return View(_productService.GetHomePageProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
