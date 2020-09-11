using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Ecommerce.Model
{
    

    [Serializable]
    public class Product
    {
        /* Auto-Implemented Properties*/
        [Key]
        public Guid ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public double ProductPrice { get; set; }

        
        /* Constructor */
        public Product()
        {
            ProductID = default(Guid);
            ProductName = null;
            ProductPrice = default(double);
           
        }
    }
}
