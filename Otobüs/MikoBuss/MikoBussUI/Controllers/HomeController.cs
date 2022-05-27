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
    
        public IActionResult BiletAl(int GuzergahId, int GuzergahPrice, string nereden, string nereye)
        {
            BiletGuzergah biletGuzergah = new BiletGuzergah();
            biletGuzergah.GuzergahId = GuzergahId;
            biletGuzergah.GuzergahPrice = GuzergahPrice;
            biletGuzergah.GuzergahStart = nereden;
            biletGuzergah.GuzerdahEnd = nereye;
            return View(biletGuzergah);
        }

        [HttpPost]
        public IActionResult BiletAl(BiletGuzergah model, int guzergahId, decimal fiyat,string baslangıc, string bitis)
        {

            var ticket = new Ticket()
            {
                TicketName = model.Ticket.TicketName,
                TicketSurname = model.Ticket.TicketSurname,
                TicketMail = model.Ticket.TicketMail,
                TicketSeatNo = model.Ticket.TicketSeatNo,
                GuzergahId = guzergahId,
                TicketPrice = fiyat,
                TicketNereden = baslangıc,
                TicketNereye = bitis,
                
                
           
            };
            _ticketService.Create(ticket);
            return RedirectToAction("Basarılı");
        }
        public IActionResult Basarılı()
        {
            return View();
        }
        
        
       
    }
}
