using Northwind.Business.Abstract;
using Northwind.Data.Access.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _CategoryDal;
        public CategoryManager(ICategoryDal CategoryDal)
        {
            _CategoryDal = CategoryDal;
        }

         
        public List<Category> GetAll()
        {
            return  _CategoryDal.GetAll();
        }
    }
}
