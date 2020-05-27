using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    public class PasswordException : Exception
    {
        public PasswordException(string message) : base(message)
        {

        }
    }
}
