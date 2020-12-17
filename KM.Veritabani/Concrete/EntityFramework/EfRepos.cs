using KM.Entities.Abstract;
using KM.Veritabani.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KM.Veritabani.Concrete.EntityFramework
{
    public class EfRepos<T, Context> : IEntityRepository<T>
        where T : class, IEntity, new()
        where Context : DbContext, new()
    {
        public void ekle(T entity)
        {
            using (Context context = new Context())
            {
                var varlik = context.Entry(entity);
                varlik.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public T getir(Expression<Func<T, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public void guncelle(T entity)
        {
            using (Context context = new Context())
            {
                var varlik = context.Entry(entity);
                varlik.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<T> listele(Expression<Func<T, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public void sil(T entity)
        {
            using (Context context = new Context())
            {
                var varlik = context.Entry(entity);
                varlik.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
