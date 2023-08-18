using Northwind.Business.Abstract;
using Northwind.Data.Access.Abstract;
using Northwind.Data.Access.Concrete;
using Northwind.Data.Access.Concrete.EntityFramework;
using Northwind.Entities;
using Northwind.Entities.Concrete;
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

        public void Add(Product product)
        {
            _Productdal.add(product);
        }

        public List<Product> GetAll ()
         {
            // business code
          

            return _Productdal.GetAll ();
         }

        public List<Product> GetProductsByCategory(int CategoryID)
        {
            return _Productdal.GetAll(p => p.CategoryID == CategoryID); 
        }

        public List<Product> GetProductsByProductName(string ProductName)
        {
            return _Productdal.GetAll(p =>p.ProductName.ToLower().Contains(ProductName.ToLower()));
        }
    }
}
