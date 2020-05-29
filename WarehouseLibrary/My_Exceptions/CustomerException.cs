using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    // Исключение связанное с действиями применимыми к классу Customer.
    //
    public class CustomerException : Exception
    {
        public CustomerException(string message) : base(message)
        {

        }
    }
}
