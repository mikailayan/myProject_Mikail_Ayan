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

        public Guzergah GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guzergah entity)
        {
            throw new NotImplementedException();
        }
    }
}
