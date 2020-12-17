
using KM.Entities.Concrete;
using KM.Veritabani.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KM.Veritabani.Concrete.EntityFramework
{
    public class EfUrunDal : EfRepos<Product, MyDbContext>, IUrunDal
    {

    }
}