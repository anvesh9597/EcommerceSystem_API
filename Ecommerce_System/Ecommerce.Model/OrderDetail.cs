
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.Model
{
   
    [Serializable]
    public class OrderDetail
    {
        [Key]
        [Required]
        public Guid OrderDetailId { get; set; } //ID of the order details
        
        public virtual Order Order { get; set; } //Foreign Key of the order placed
        public bool IsCancelled { get; set; } = false;//cancellation status
        [Required]
        public Guid ProductID { get; set; } //ID of the product
        public int ProductQuantityOrdered { get; set; }//quantity of the product ordered
        public double ProductPrice { get; set; }//price of the product
        
        [Required]
        public Guid AddressId { get; set; }//address ID of the address to which the product has to be delivered
        public double TotalAmount { get; set; } //Revenue through product
        public DateTime DateOfOrder { get; set; }//date of ordering
        public int OrderSerial { get; set; }//order serial is equal to OrderNumber
    }
}
