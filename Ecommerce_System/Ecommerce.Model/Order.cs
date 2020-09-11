
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Model
{

    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } //ID of the order

        //public ApplicationUser Id { get; set; } //ID of the retailer
        public virtual ApplicationUser ApplicationUser { get; set; }
        public DateTime DateOfOrder { get; set; } //Date of placing order
        public int TotalQuantity { get; set; } //Total quantity of the products ordererd
        public DateTime LastModifiedDateTime { get; set; }//date of order modification
        public double OrderAmount { get; set; }//total cost of the order

        public OrderStatus status; //Gives the status of the order
        public double OrderNumber { get; set; } = 0;//order no of the retailer

        public ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
