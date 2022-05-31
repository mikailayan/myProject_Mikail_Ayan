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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            _ticketRepository.Create(ticket);
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            var entity = _ticketRepository.GetById(id);
            var ticket = new Ticket()
            {
                TicketId=id,
                TicketName = entity.TicketName,
                TicketMail = entity.TicketMail,
                TicketNereden = entity.TicketNereden,
                TicketNereye = entity.TicketNereye,
                TicketPrice = entity.TicketPrice,
                TicketSeatNo= entity.TicketSeatNo,
                TicketSurname= entity.TicketSurname,
                GuzergahId = entity.GuzergahId,
                
            };
            return View(ticket);
        }
        [HttpPost]
        public IActionResult Edit(Ticket ticket)
        {
            var ticko = new Ticket()
            {
                TicketId = ticket.TicketId,
                TicketName = ticket.TicketName,
                TicketPrice = ticket.TicketPrice,
                TicketNereden = ticket.TicketNereden,
                TicketMail =  ticket.TicketMail,
                TicketNereye = ticket.TicketNereye,
                TicketSeatNo = ticket.TicketSeatNo,
                TicketSurname = ticket.TicketSurname,
                GuzergahId = ticket.GuzergahId,
            };
            _ticketRepository.Update(ticko);
            return RedirectToAction("index");
        }
       public IActionResult Details(int id)
        {
            var entity = _ticketRepository.GetById(id);
            var ticket = new Ticket()
            {
                TicketId = id,
                TicketName = entity.TicketName,
                TicketMail = entity.TicketMail,
                TicketNereden = entity.TicketNereden,
                TicketNereye = entity.TicketNereye,
                TicketPrice = entity.TicketPrice,
                TicketSeatNo = entity.TicketSeatNo,
                TicketSurname = entity.TicketSurname,
                GuzergahId = entity.GuzergahId,

            };
            return View(ticket);
        }
    }
}
