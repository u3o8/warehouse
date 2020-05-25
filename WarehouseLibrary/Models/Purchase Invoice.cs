using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class PurchaseInvoice : Invoice
    {
        public PurchaseInvoice(List<Portion> portions) : base(portions)
        {
        
        }
        
    }
}
