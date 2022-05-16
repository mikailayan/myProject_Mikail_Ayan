using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussBusinessLayer
{
    public interface ITicketService
    {
        void Create(Ticket entity);
        void Delete(Ticket entity);
        void Update(Ticket entity);
        List<Ticket> GetAll();
        Ticket GetById(int id);
    }
}
