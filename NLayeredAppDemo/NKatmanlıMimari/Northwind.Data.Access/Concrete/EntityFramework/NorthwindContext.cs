﻿using Northwind.Entities;//entities.concrete?
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Access.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
