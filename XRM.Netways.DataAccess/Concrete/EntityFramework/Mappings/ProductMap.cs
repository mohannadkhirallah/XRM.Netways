using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.DataAccess.Concrete.EntityFramework.Mappings
{
    internal class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products","dbo");
            HasKey(x => x.ProdudctId);

            Property(x => x.ProdudctId).HasColumnName("ProductID");
            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");



        }
    }
}
