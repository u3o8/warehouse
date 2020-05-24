using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseLibrary.Models;

namespace AdminApp
{
    public partial class Home_Page : Form
    {
        Warehouse warehouse;
        public Home_Page(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            productBindingSource.DataSource = warehouse.Products;
            orderBindingSource.DataSource = warehouse.Orders;
            customerBindingSource.DataSource = warehouse.Customers;
        }
    }
}
