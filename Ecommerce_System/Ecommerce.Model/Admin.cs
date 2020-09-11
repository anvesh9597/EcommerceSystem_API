using System;
using Ecommerce.Exceptions;

namespace Ecommerce.Model
{
  
    public class Admin : IUser
    {
        [Required("Admin ID can't be blank.")]
        public Guid AdminID { get; set; }

        [Required("Admin Name can't be blank.")]
        public string AdminName { get; set; }

        [Required("Login ID can't be blank.")]
        public string LoginID { get; set; }

        [Required("Password can't be blank.")]
        public string Password { get; set; }


        public Admin()
        {
            AdminID = default(Guid);
            AdminName = null;
            LoginID = null;
            Password = null;
        }
    }
}
