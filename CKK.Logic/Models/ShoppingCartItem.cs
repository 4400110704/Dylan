﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class ShoppingCartItem
    {
        private Product Product { get; set; }
        private int Quantity { get; set; }
        public ShoppingCartItem(Product Product, int Quantity)
        {

        }
    }
}
