using KM.Business.Abstract;
using KM.Entities.Concrete;
using KM.Veritabani.Abstract;
using KM.Veritabani.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM.Business.Concrete
{
    public class UrunKontrol : IUrunServis
    {
        private IUrunDal _urunDal;
        public UrunKontrol(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public void ekle(Product product)
        {
            _urunDal.ekle(product);
        }

        public void guncelle(Product product)
        {
            _urunDal.guncelle(product);
        }

        public List<Product> ismeGöre(string text)
        {
            return _urunDal.listele(p => p.ProductName.ToLower().Contains(text.ToLower()));
        }

        public List<Product> kategoriyeGöre(int kategoriId)
        {
            return _urunDal.listele(p => p.CategoryId == kategoriId);
        }

        public List<Product> listele()
        {
            return _urunDal.listele();
        }

        public void sil(Product product)
        {
            _urunDal.sil(product);
        }
    }
}