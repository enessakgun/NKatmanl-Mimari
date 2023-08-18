using Northwind.Entities;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Access.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        void add(T entity);
        void update(T entity);
        void delete(T entity   );
    }
}
