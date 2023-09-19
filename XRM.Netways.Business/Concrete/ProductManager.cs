using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Netways.DataAccess.Abstract;
using XRM.Netways.DataAccess.Concrete.EntityFramework;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.Business.Concrete
{
    public class ProductManager
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }
    }
}
