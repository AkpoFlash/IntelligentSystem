using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class Store
    {

        public List<Product> Products { get; set; } = new List<Product>();
        public List<WorkedCustomer> Customers { get; set; } = new List<WorkedCustomer>();

        public Store() { }

        public Store(List<Product> products, List<WorkedCustomer> customers)
        {
            this.Products = products;
            this.Customers = customers;
        }

        public void SetDiscountForCategory(decimal discountPercent, Enumerable.Category category)
        {
            foreach (var product in this.Products)
            {
                if (product.Category == category && product.DiscountPercent < discountPercent)
                {
                    product.DiscountPercent = discountPercent;
                }
            }
        }

        public void SetDiscountForCategory(decimal discountPercent, Enumerable.Category[] categories)
        {
            foreach (var product in this.Products)
            {
                foreach (var category in categories)
                {
                    if (product.Category == category && product.DiscountPercent < discountPercent)
                    {
                        product.DiscountPercent = discountPercent;
                    }
                }
            }
        }

    }
}
