using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Core.DataAccess;
using XRM.Netways.Entities.Concrete;

namespace XRM.Netways.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // This can be used only for Entity Model specific like getting the most selling product. then you can add the contract/method
        // In other word any special methods related to product ! 


    }
}
