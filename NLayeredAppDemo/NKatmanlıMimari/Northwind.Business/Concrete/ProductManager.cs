using Northwind.Business.Abstract;
using Northwind.Data.Access.Abstract;
using Northwind.Data.Access.Concrete;
using Northwind.Data.Access.Concrete.EntityFramework;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager: IProductService
    {
        private IProductDal _Productdal;
        public ProductManager(IProductDal productDal)
        { 
            _Productdal = productDal;
        }

      
        public List<Product> GetAll ()
         {
            // business code
          

            return _Productdal.GetAll ();
         }

    }
}
