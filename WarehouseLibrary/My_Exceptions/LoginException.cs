using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    class LoginException : ArgumentException
    {
        public LoginException(string message) : base(message)
        { 
        }
    }
}
