using Ninject;
using System;
using System.Reflection;
using XRM.Core.Utlities.Infrastructure.Ninject;
using XRM.Netways.Business.Abstract;
using XRM.Netways.Business.Concrete;
using XRM.Netways.Business.DependencyResolver.Ninject;
using XRM.Netways.DataAccess.Concrete.EntityFramework;

namespace XRM.Netways.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // IProductService service = new ProductManager(new EfProductDal());

            var factory = new NinjectConsoleFactory(new BusinessModule());

            var kernel = factory.GetKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IProductService service = kernel.Get<IProductService>();


            foreach (var item in service.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadLine();

        }
    }
}
