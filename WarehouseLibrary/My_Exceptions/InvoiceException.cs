using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    // Исключение связанное с действиями применимыми к классу Invoice и ее наследникам.
    //
    public class InvoiceException : Exception
    {
        public InvoiceException(string message) : base(message)
        {

        }
    }
}
