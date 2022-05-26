using MikoBussDataAccessLayer.Abstract;
using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussBusinessLayer.Concrete
{
    public class GuzergahManager : IGuzergahService
    {
        private IGuzergahRepository _guzergahRepository;
        public GuzergahManager(IGuzergahRepository guzergahRepository)
        {
            _guzergahRepository = guzergahRepository;
        }
        public void Create(Guzergah entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guzergah entity)
        {
            throw new NotImplementedException();
        }

        public List<Guzergah> GetAll()
        {
            return _guzergahRepository.GetAll();
        }

        public List<Guzergah> GetBusListByRoute(string nereden, string nereye)
        {
            return _guzergahRepository.GetBusListByRoute(nereden, nereye);
        }

        public Guzergah GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Guzergah GetGuzergahId(int id)
        {
            return _guzergahRepository.GetGuzergahId(id);
        }

        public List<Guzergah> GetNeredenNereye(string nereden, string nereye)
        {
            return _guzergahRepository.GetNeredenNereye(nereden, nereye);
        }

        public Guzergah GetPrice(string nereden, string nereye)
        {
            return _guzergahRepository.GetPrice(nereden, nereye);
        }

        public void Update(Guzergah entity)
        {
            throw new NotImplementedException();
        }
    }
}
