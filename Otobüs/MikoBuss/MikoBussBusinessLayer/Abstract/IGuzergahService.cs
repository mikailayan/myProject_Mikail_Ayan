using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussBusinessLayer
{
    public interface IGuzergahService
    {
        void Create(Guzergah entity);
        void Delete(Guzergah entity);
        void Update(Guzergah entity);
        List<Guzergah> GetAll();
        Guzergah GetById(int id);
        public List<Guzergah> GetBusListByRoute(string nereden, string nereye);
        public Guzergah GetPrice(string nereden, string nereye);

        public List<Guzergah> GetNeredenNereye(string nereden, string nereye);
        Guzergah GetGuzergahId(int id);




    }
}
