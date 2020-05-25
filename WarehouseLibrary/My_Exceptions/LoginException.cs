using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    public class LoginException : ArgumentException
    {
        public LoginException(string message) : base(message)
        { 

        }
    }
}
