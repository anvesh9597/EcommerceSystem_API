using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    class Cart
    {
        public Guid CartId { get; set; } //ID of the cart
        public Guid UserID { get; set; } //ID of the retailer

        public int TotalQuantity { get; set; } //Total quantity of the products ordererd
        public double TotalAmount { get; set; } //Cart value
    }
}
