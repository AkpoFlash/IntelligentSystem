using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class Store
    {
        public Dictionary<Enumerable.Proffesion, Enumerable.Category> ProffesionCategory { get; set; } = new Dictionary<Enumerable.Proffesion, Enumerable.Category>();

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
