using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussDataAccessLayer.Abstract
{
    public interface ICityRepository : IRepository<City>
    {
        public List<City> GetNereden (string nereden);
        public List<City> GetNereye (string nereye);

    }
}
