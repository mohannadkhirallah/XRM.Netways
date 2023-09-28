using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllProductsByCategory(int Category);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
