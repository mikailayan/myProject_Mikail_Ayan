using MikoBussDataAccessLayer.Abstract;
using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussDataAccessLayer.Concrete
{
    public class EfCoreGuzergahRepository : EfCoreGenericRepository<Guzergah,MikoBussContext> , IGuzergahRepository
    {
    }
}
