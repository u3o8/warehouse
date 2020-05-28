using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    public class SupplyException : Exception
    {
        public SupplyException(string message) : base(message)
        {

        }
    }
}
