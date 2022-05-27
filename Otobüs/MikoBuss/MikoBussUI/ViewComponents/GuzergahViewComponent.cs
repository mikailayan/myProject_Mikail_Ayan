using Microsoft.AspNetCore.Mvc;
using MikoBussBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikoBussUI.ViewComponents
{
    public class GuzergahViewComponent : ViewComponent
    {
        private IGuzergahService _guzergahService;
        public GuzergahViewComponent(IGuzergahService guzergahService, string nereden, string nereye)
        {
            _guzergahService = guzergahService;
        }
        public IViewComponentResult Invoke(string nereden, string nereye)
        {
            
            return View(_guzergahService.GetBusListByRoute(nereden, nereye));  //Düzenlenecek...@@@@@@@@@@@@@@@@
        }
    }
}
