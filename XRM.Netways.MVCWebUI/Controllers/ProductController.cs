
using System.Web.Mvc;
using XRM.Netways.Business.Abstract;
using XRM.Netways.Business.Concrete;
using XRM.Netways.DataAccess.Concrete.EntityFramework;
using XRM.Netways.MVCWebUI.Models;

namespace XRM.Netways.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index()
        {
            //IProductService service = new ProductManager(new EfProductDal());

            var model = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };

            return View(model);
        }
    }
}