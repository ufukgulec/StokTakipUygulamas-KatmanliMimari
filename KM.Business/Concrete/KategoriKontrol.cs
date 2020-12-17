using KM.Business.Abstract;
using KM.Entities.Concrete;
using KM.Veritabani.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM.Business.Concrete
{
    public class KategoriKontrol : IKategoriServis
    {
        private IKategoriDal _kategoriDal;
        public KategoriKontrol(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }
        public List<Category> listele()
        {
            return _kategoriDal.listele();
        }
    }
}
