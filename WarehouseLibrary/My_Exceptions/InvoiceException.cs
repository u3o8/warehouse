using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    public class InvoiceException : Exception
    {
        public InvoiceException(string message) : base(message)
        {

        }
    }
}
