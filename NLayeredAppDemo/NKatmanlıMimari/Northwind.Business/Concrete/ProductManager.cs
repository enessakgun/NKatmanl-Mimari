using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Data.Access.Abstract;
using Northwind.Data.Access.Concrete;
using Northwind.Data.Access.Concrete.EntityFramework;
using Northwind.Entities;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ValidationException = FluentValidation.ValidationException;

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
            ValidationTool.Validate(new ProductValidator(), product);
            _Productdal.add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _Productdal.delete(product);
            }
            catch 
            {

                throw new Exception("silme işlemi gerçekleşmedi.");
            }
           
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

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _Productdal.update(product);
        }
    }
}

