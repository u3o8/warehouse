using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    // Исключение связанное с действиями применимыми к свойству Login в классе User.
    //
    public class LoginException : ArgumentException
    {
        public LoginException(string message) : base(message)
        { 

        }
    }
}
