﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    public class CartProduct
    {
        public Guid CartProductID { get; set; } //ID of the cart product
        public Guid CartId { get; set; } //ID of the cart

        public Guid ProductID { get; set; } //ID of the product
        public int ProductQuantityOrdered { get; set; }//quantity of the product ordered
        public double ProductPrice { get; set; }//price of the product
        public Guid AddressId { get; set; }//address ID of the address to which the product has to be delivered
        public double TotalAmount { get; set; } //Revenue through product
    }
}