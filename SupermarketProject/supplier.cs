﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    public class Supplier
    {
        string? name;
        string? typeofproduct;
        int stock;
        public Products[]? product;

        public Supplier(string? name, string? typeofproduct, int stock)
        {
            this.name = name;
            this.typeofproduct = typeofproduct;
            this.stock = stock;
        }

        public string? Name{
            get
            {
                return name;
            }
        }

        public string? TypeOfProduct
        {
            get
            {
                return typeofproduct;
            }
        }

        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }
    }
}
