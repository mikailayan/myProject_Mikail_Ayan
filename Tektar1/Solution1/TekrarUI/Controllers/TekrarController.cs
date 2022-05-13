using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekrarBusinessLayer.Abstract;
using TekrarUI.Models;

namespace TekrarUI.Controllers
{
    public class TekrarController : Controller
    {
        private IProductService _productService;
        public TekrarController(IProductService productService)
        {
            _productService = productService;
        }


        public IActionResult List(string category, int page=1)
        {
            ViewBag.Message = "Ürün Bulunamadı";
            ViewBag.AlertType = "warning";
            return View(); //GEldim

            const int pageSize = 5;//bu değişken her sayfada kaç item görüneceğini tutacak
            int totalItems = _productService.GetCountByCategory(category);
            var productListViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category, page, pageSize)
            };
            return View(productListViewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
