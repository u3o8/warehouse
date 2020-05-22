using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Sales_Invoice : Invoice
    {
        public Sales_Invoice(List<Portion> portions, Customer customer) : base(portions) {
            Customer = customer;
        }
        Customer Customer { get; set; }
    }
}
