using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Purchase_Invoice : Invoice
    {
        public Purchase_Invoice(List<Portion> portions) : base(portions) { }
        
    }
}
