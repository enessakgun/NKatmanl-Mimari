using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Access.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
