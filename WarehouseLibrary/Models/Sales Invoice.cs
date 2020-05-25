using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class SalesInvoice : Invoice
    {
        public SalesInvoice(List<Portion> portions, Customer customer) : base(portions) 
        {
            Customer = customer;
        }
        Customer Customer { get; set; }
    }
}
