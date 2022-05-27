using Microsoft.EntityFrameworkCore;
using MikoBussDataAccessLayer.Abstract;
using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussDataAccessLayer.Concrete
{
    public class EfCoreGuzergahRepository : EfCoreGenericRepository<Guzergah, MikoBussContext>, IGuzergahRepository
    {
        public List<Guzergah> GetBusListByRoute(string nereden, string nereye)
        {
            using (var context = new MikoBussContext())
            {
                var neredenn = context
                    .Cities
                    .Where(i => i.CityId == Convert.ToInt32(nereden))
                    .Select(i => i.CiytName).FirstOrDefault();

                var nereyee = context
                    .Cities
                    .Where(i => i.CityId == Convert.ToInt32(nereye))
                    .Select(i => i.CiytName).FirstOrDefault();
                   
                var xx = context
                    .Guzergahs
                    .Where(i => i.GuzergahStart == Convert.ToString(neredenn) && i.GuzergahEnd == Convert.ToString(nereyee))
                    .ToList();
                return xx;
            }
        }

        public Guzergah GetGuzergahId(int id)
        {
            using (var context = new MikoBussContext())
            {
                return context
                    .Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .FirstOrDefault();
            }
        }

        public List<Guzergah> GetNeredenNereye(string nereden, string nereye)
        {
            throw new NotImplementedException();
        }

        public Guzergah GetPrice(string nereden, string nereye)
        {
            using (var context = new MikoBussContext())
            {
                var neredenn = context
                    .Cities
                    .Where(i => i.CityId == Convert.ToInt32(nereden))
                    .Select(i => i.CiytName)
                    .FirstOrDefault();
                var nereyee = context
                    .Cities
                    .Where(i => i.CityId == Convert.ToInt32(nereye))
                    .Select(i => i.CiytName)
                    .FirstOrDefault();
                var xx = context
                    .Guzergahs
                    .Where(i => i.GuzergahStart == neredenn && i.GuzergahEnd == nereyee)
                    .FirstOrDefault();
                return xx;
            }
        }
    }
}
