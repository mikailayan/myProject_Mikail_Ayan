using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikoBussUI.Controllers
{
    public class TurlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
