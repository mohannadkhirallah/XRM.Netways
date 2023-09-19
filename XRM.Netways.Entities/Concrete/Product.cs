
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using XRM.Core.Entities;

namespace XRM.Netways.Entities.Concrete
{
    public class Product :IEntity
    {
        public int ProdudctId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
