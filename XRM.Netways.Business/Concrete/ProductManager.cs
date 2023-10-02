using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Core.Aspect.Postsharp.ValidationAspect;
using XRM.Core.CrossCuttingConcerns.Validation.FluentValidation;
using XRM.Netways.Business.Abstract;
using XRM.Netways.Business.ValidationRules.FluentValidation;
using XRM.Netways.DataAccess.Abstract;
using XRM.Netways.DataAccess.Concrete.EntityFramework;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.Business.Concrete
{
    public class ProductManager :IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        { 
            
            // Business validation and Rules
            //ValidationTool.FluentValidate(new ProductValidator(), product);

            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetAllProductsByCategory(int Category)
        {
            return _productDal.GetList(p => p.CategoryId == Category);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
