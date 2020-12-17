using KM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM.Veritabani.Concrete.EntityFramework
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}
