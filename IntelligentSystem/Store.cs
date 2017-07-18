using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class Store
    {

        public List<Product> Products { get; set; }
        public List<WorkedCustomer> Customers { get; set; }

        public Store() { }

        public Store(List<Product> products, List<WorkedCustomer> customers)
        {
            this.Products = products;
            this.Customers = customers;
        }

    }
}
