using System;

namespace Ecommerce.Exceptions
{
    public class RequiredAttribute:Attribute
    {
        public string ErrorMessage { get; set; }
        public RequiredAttribute() : base()
        {
        }

        public RequiredAttribute(string errorMessage) : base()
        {
            ErrorMessage = errorMessage;
        }
    }
}
