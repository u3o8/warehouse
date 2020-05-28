using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    public class CustomerException : Exception
    {
        public CustomerException(string message) : base(message)
        {

        }
    }
}
