using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Netways.Business.Abstract;
using XRM.Netways.Business.Concrete;
using XRM.Netways.DataAccess.Abstract;
using XRM.Netways.DataAccess.Concrete.EntityFramework;

namespace XRM.Netways.Business.DependencyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>(); // simply this is what ninject does => ProductManager x = new ProductManager();
            Bind<IProductDal>().To<EfProductDal>();   
        }
    }
}
