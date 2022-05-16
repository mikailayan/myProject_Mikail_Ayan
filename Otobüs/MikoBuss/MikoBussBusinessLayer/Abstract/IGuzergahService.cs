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
    }
}
