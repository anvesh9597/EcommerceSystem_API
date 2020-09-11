using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Exceptions
{
    public class EcommerceException:ApplicationException
    {
        public EcommerceException() : base() { }
        public EcommerceException(string message) : base(message) { }
        public EcommerceException(string message,Exception innerException) : base(message,innerException) { }

    }
}
