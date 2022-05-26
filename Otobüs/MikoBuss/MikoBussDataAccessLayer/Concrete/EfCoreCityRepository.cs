using MikoBussDataAccessLayer.Abstract;
using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussDataAccessLayer.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, MikoBussContext>, ICityRepository
    {
        public List<City> GetNereden(string nereden)
        {
            using (var context = new MikoBussContext())
            {
                var nrdn = context
                    .Cities
                    .Where(i => i.CiytName == nereden)
                    .ToList();
                return nrdn;
            }
        }

        public List<City> GetNereye(string nereye)
        {
            throw new NotImplementedException();
        }
    }
}
