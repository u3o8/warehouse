using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    public class SupplyException : Exception
    {
        // Исключение связанное с действиями применимыми к поставке.
        //
        public SupplyException(string message) : base(message)
        {

        }
    }
}
