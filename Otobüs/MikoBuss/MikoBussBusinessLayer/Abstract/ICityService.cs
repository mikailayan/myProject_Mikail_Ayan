using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussBusinessLayer
{
    public interface ICityService
    {
        void Create(City entity);
        void Delete(City entity);
        void Update(City entity);
        List<City> GetAll();
        City GetById(int id);
    }
}
