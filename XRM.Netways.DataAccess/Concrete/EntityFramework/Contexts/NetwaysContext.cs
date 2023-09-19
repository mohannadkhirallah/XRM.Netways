using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Netways.DataAccess.Concrete.EntityFramework.Mappings;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NetwaysContext:DbContext
    {
        public NetwaysContext()
        {
            Database.SetInitializer<NetwaysContext>(null);
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

    }
}
