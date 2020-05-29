using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.My_Exceptions
{
    // Исключение связанное с действиями применимыми к свойству Password в классе User.
    //
    public class PasswordException : Exception
    {
        public PasswordException(string message) : base(message)
        {

        }
    }
}
