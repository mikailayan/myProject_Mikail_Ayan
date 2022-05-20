using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MikoBussBusinessLayer;
using MikoBussEntityLayer;
using MikoBussUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MikoBussUI.Controllers
{
    public class HomeController : Controller
    {
        private IGuzergahService _guzergahService;
        private ICityService _cityService;
        private ITicketService  _ticketService;

        public HomeController(ICityService cityService, IGuzergahService guzergahService, ITicketService ticketService)
        {
            _cityService = cityService;
            _guzergahService = guzergahService;
            _ticketService = ticketService;

            
        }
        public IActionResult Index()
        {

            var sehirmodel = new BiletGuzergah()
            {
                Cities = _cityService.GetAll()
            };
            ViewBag.Sehirler = new SelectList(sehirmodel.Cities, "CityId", "CiytName");
            return View(sehirmodel);

        }
        [HttpPost]
        public IActionResult Index(string nereden, string nereye)
        {
            var sehirler = new BiletGuzergah()
            {
                Cities = _cityService.GetAll(),
                Guzergahs = _guzergahService.GetBusListByRoute(nereden, nereye)
            };
            ViewBag.Sehirler = new SelectList(sehirler.Cities, "CityId", "CiytName");
            return View(sehirler);
        }
        public IActionResult Basarılı()
        {
            return View();
        }
        public IActionResult NewTicket()
        {
            return View("privacy");
        }
        [HttpPost]
        public IActionResult NewTicket(Ticket ticket)
        {
           
            return RedirectToAction("Basarılı");
        }
        public IActionResult deneme()
        {

          var context= _cityService.GetAll();

            ViewData["Veri"] = "Bu bir ViewData'da taşınan veridir.";
            ViewBag.Veri = "Bu bir ViewBag'de taşınan veridir.";
            TempData["Veri"] = "Bu bir TempDate'da taşınan veridir.";
            ViewBag.Veri2 = context;
            return View();
        }
        public IActionResult deneme2()
        {
            var ViewDataVeri = ViewData["Veri"];
            var ViewBagVeri = ViewBag.Veri;
            var TempDateVeri = TempData["Veri"];
            return View();
        }
        public IActionResult BiletAl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BiletAl(Ticket ticket)
        {
            _ticketService.Create(ticket);
            return View();
        }

        
        
       
    }
}
