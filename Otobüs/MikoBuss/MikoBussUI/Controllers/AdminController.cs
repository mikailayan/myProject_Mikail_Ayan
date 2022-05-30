using Microsoft.AspNetCore.Mvc;
using MikoBussDataAccessLayer.Abstract;
using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikoBussUI.Controllers
{
    public class AdminController : Controller
    {
        private IGuzergahRepository _guzergahRepository;
        private ITicketRepository _ticketRepository;
        private ICityRepository _cityRepository;
        public AdminController(IGuzergahRepository guzergahRepository, ITicketRepository ticketRepository, ICityRepository cityRepository)
        {
            _guzergahRepository = guzergahRepository;
            _ticketRepository = ticketRepository;
            _cityRepository = cityRepository;
            
        }
        public IActionResult Index()
        {
            return View(_ticketRepository.GetAll());
        }
        [HttpPost]
        public IActionResult Delete(int ticketId)
        {
            var entity = _ticketRepository.GetById(ticketId);
            _ticketRepository.Delete(entity);
            return RedirectToAction("index");
        }
    }
}
