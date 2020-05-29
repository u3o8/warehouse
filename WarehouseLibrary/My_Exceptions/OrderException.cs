using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    // Исключение связанное с действиями применимыми к классу Order.
    //
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        {

        }
    }
}
