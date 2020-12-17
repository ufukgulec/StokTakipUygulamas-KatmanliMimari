using KM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM.Business.Abstract
{
    public interface IUrunServis
    {
        List<Product> listele();
        List<Product> kategoriyeGöre(int kategoriId);
        List<Product> ismeGöre(string text);
        void ekle(Product product);
        void guncelle(Product product);
        void sil(Product product);
    }
}
