using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Customer : User
    {
        public string Adress { set; get; }

    }
}
