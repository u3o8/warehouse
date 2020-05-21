using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        {
        }
    }
}
