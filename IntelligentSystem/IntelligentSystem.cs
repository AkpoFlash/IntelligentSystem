using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    static class IntelligentSystem
    {
        static IntelligentStore store = new IntelligentStore();

        static public void InitializeProduct()
        {
            store.Products.Add(new Product(0, 0, "Ball", 10, Enumerable.Category.Sport));
            store.Products.Add(new Product(1, 88, "Bananas", 20, Enumerable.Category.Cookery));
            store.Products.Add(new Product(2, 19, "Set of bricks", 100, Enumerable.Category.Building));
            store.Products.Add(new Product(3, 5, "Oven", 1000, Enumerable.Category.House, 90));
        }

        static public void InitializeWorkedPeople()
        {
            store.Customers.Add(new WorkedCustomer(0, "Mary", 100, Enumerable.Proffesion.Housewife));
            store.Customers.Add(new WorkedCustomer(1, "Peter", 500, Enumerable.Proffesion.Builder));
            store.Customers.Add(new WorkedCustomer(2, "Mike", 2000, Enumerable.Proffesion.Sportsman));
            store.Customers.Add(new WorkedCustomer(3, "Kate", 400, Enumerable.Proffesion.Cook));
        }

        static public void DiscountForCategories()
        {
            Enumerable.Category[] discountCategories = new Enumerable.Category[] {
                Enumerable.Category.House,
                Enumerable.Category.Cookery
            };

            store.SetDiscountForCategory(50, discountCategories);
        }

        static public void CalculateRelevantProducts()
        {
            store.ProffesionCategory.Add(Enumerable.Proffesion.Housewife, Enumerable.Category.House);
            store.ProffesionCategory.Add(Enumerable.Proffesion.Builder, Enumerable.Category.Building);
            store.ProffesionCategory.Add(Enumerable.Proffesion.Sportsman, Enumerable.Category.Sport);
            store.ProffesionCategory.Add(Enumerable.Proffesion.Cook, Enumerable.Category.Cookery);
            store.GetRelevantProduct();
        }

        static public void OutputResult()
        {
            foreach (var str in store.RelevantProduct)
            {
                Console.WriteLine("Customer Name: {0}; Product Name {1};", str.Key, str.Value);
            }
        }

        static public void OutputProducts()
        {
            foreach (var product in store.Products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine();
        }

    }
}
