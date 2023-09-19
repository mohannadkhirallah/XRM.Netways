using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XRM.Core.DataAccess.EntityFramework;
using XRM.Netways.DataAccess.Abstract;
using XRM.Netways.DataAccess.Concrete.EntityFramework.Contexts;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityFrameworkRepositoryBase<Product, NetwaysContext>, IProductDal
    {
       
    }
}
