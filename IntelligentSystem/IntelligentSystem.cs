using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentSystem.Core;

namespace IntelligentSystem
{
    static class IntelligentSystem
    {
        static IntelligentStore store = new IntelligentStore();

        static public void InitializeProduct()
        {
            store.Products.Add(new Product(0, 0, "Ball", 10, Category.Sport));
            store.Products.Add(new Product(1, 88, "Bananas", 20, Category.Cookery));
            store.Products.Add(new Product(2, 19, "Set of bricks", 100, Category.Building));
            store.Products.Add(new Product(3, 5, "Oven", 1000, Category.House, 90));
        }

        static public void InitializeWorkedPeople()
        {
            store.Customers.Add(new WorkedCustomer(0, "Mary", 100, Proffesion.Housewife));
            store.Customers.Add(new WorkedCustomer(1, "Peter", 500, Proffesion.Builder));
            store.Customers.Add(new WorkedCustomer(2, "Mike", 2000, Proffesion.Sportsman));
            store.Customers.Add(new WorkedCustomer(3, "Kate", 400, Proffesion.Cook));
        }

        static public void DiscountForCategories()
        {
            Category[] discountCategories = new Category[] {
                Category.House,
                Category.Cookery
            };

            store.SetDiscountForCategory(50, discountCategories);
        }

        static public void CalculateRelevantProducts()
        {
            store.ProffesionCategory.Add(Proffesion.Housewife, Category.House);
            store.ProffesionCategory.Add(Proffesion.Builder, Category.Building);
            store.ProffesionCategory.Add(Proffesion.Sportsman, Category.Sport);
            store.ProffesionCategory.Add(Proffesion.Cook, Category.Cookery);
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
