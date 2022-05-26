using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussDataAccessLayer.Abstract
{
    public interface IGuzergahRepository : IRepository<Guzergah>
    {
        public List<Guzergah> GetBusListByRoute(string nereden, string nereye);
        public Guzergah GetPrice(string nereden, string nereye);
        public List<Guzergah> GetNeredenNereye(string nereden, string nereye);
        Guzergah GetGuzergahId(int id);

    }
}
