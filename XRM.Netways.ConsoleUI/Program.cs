using System;
using XRM.Netways.Business.Abstract;
using XRM.Netways.Business.Concrete;
using XRM.Netways.DataAccess.Concrete.EntityFramework;

namespace XRM.Netways.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService service = new ProductManager(new EfProductDal());

            foreach (var item in service.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadLine();

        }
    }
}
