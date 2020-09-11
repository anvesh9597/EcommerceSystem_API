using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Exceptions;

namespace Ecommerce.Model
{

    [Serializable]
    public class User :  IUser
    {
        [Required("User ID can't be blank.")]
        public Guid UserID { get; set; }

        [Required("User Name can't be blank.")]
        public string UserName { get; set; }

        [Required("User Login ID can't be blank.")]
        public string LoginID { get; set; }

        [Required("Password can't be blank.")]
        public string Password { get; set; }


        public User()
        {
            UserID = default(Guid);
            UserName = null;
            LoginID = null;
            Password = null;
        }
    }
}
