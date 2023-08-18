using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Access.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
