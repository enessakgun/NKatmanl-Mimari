﻿using FluentValidation;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
 public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {

            RuleFor(p => p.ProductName).NotEmpty().WithMessage("ürün ismi boş olamaz.");
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();


            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryID==2);

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürün adı A ile başlamalı");
        }

       

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
