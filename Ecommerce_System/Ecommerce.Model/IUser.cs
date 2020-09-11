using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    public interface IUser
    {
        string LoginID { get; set; }
        string Password { get; set; }
    }
}
