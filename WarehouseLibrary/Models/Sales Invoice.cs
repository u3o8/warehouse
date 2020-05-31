using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Расходная накладная - это это коллекция порций + дата + покупатель + стоимость всего заказа.
    //
    [Serializable]
    public class SalesInvoice : Invoice
    {
        public SalesInvoice(List<Portion> portions, Customer customer, decimal totalPrice) : base(portions) 
        {
            Customer = customer;
            TotalPrice = totalPrice;
        }
        Customer Customer { get; set; }
        public string CustomerLogin { get => Customer.Login; }
        public decimal TotalPrice { private set; get; }

    }
}
