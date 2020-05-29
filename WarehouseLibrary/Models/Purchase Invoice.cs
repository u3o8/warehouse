using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Приходная накладная - это это коллекция порций + дата.
    //
    [Serializable]
    public class PurchaseInvoice : Invoice
    {
        public PurchaseInvoice(List<Portion> portions) : base(portions)
        {
        
        }
        
    }
}
