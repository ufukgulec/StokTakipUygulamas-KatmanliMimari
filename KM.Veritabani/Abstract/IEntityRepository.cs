using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KM.Entities.Abstract;
namespace KM.Veritabani.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> listele(Expression<Func<T, bool>> filter = null);
        T getir(Expression<Func<T, bool>> filter);
        void ekle(T entity);

        void guncelle(T entity);

        void sil(T entity);
    }
}
