using KM.Entities.Concrete;
using KM.Veritabani.Abstract;
using KM.Veritabani.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM.Veritabani.Concrete.EntityFramework
{
    public class EfKategoriDal : EfRepos<Category, MyDbContext>,IKategoriDal
    {

    }
}
