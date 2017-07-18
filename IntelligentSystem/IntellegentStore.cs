using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class IntellegentStore : Store
    {
        public Dictionary<Enumerable.Proffesion, Enumerable.Category> ProffesionCategory { get; set; } = new Dictionary<Enumerable.Proffesion, Enumerable.Category>();
        public Dictionary<string, string> RelevantProduct { get; set; } = new Dictionary<string, string>();

        public IntellegentStore() { }

        public IntellegentStore(List<Product> products, List<WorkedCustomer> customers) : base(products, customers) { }

        public Dictionary<string, string> GetRelevantProduct(List<Product> products, List<WorkedCustomer> customers)
        {
            foreach (var product in products)
            {
                foreach (var customer in customers)
                {
                    if (CheckForRelevanted(product, customer))
                    {
                        this.RelevantProduct.Add(customer.Name, product.Name);
                    }
                }
            }

            return this.RelevantProduct;
        }

        private bool CheckForRelevanted(Product product, WorkedCustomer customer)
        {
            return ProffesionCategory.ContainsKey(customer.Prof) && ProffesionCategory[customer.Prof].Equals(product.Category) && product.Cost < customer.Money && product.Count > 0;
        }

    }
}
