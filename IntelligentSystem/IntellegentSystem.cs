﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class IntellegentSystem
    {
        static List<Product> products = new List<Product>();
        static List<WorkedCustomer> workedPeople = new List<WorkedCustomer>();
        static IntellegentStore store = new IntellegentStore();

        static void Main(string[] args)
        {
            InitializeProduct();
            InitializeWorkedPeople();
            CalculateRelevantProducts();
            OutputResult();

            Console.ReadKey();
        }

        static void InitializeProduct()
        {
            products.Add(new Product(0, 0, "Ball", 10, Enumerable.Category.Sport));
            products.Add(new Product(1, 88, "Bananas", 20, Enumerable.Category.Cookery));
            products.Add(new Product(2, 19, "Set of bricks", 100, Enumerable.Category.Building));
            products.Add(new Product(3, 5, "Oven", 1000, Enumerable.Category.House));
        }

        static void InitializeWorkedPeople()
        {
            workedPeople.Add(new WorkedCustomer(0, "Mary", 100, Enumerable.Proffesion.Housewife));
            workedPeople.Add(new WorkedCustomer(1, "Peter", 500, Enumerable.Proffesion.Builder));
            workedPeople.Add(new WorkedCustomer(2, "Mike", 2000, Enumerable.Proffesion.Sportsman));
            workedPeople.Add(new WorkedCustomer(3, "Kate", 400, Enumerable.Proffesion.Cook));
        }

        static void CalculateRelevantProducts()
        {
            store.ProffesionCategory.Add(Enumerable.Proffesion.Housewife, Enumerable.Category.House);
            store.ProffesionCategory.Add(Enumerable.Proffesion.Builder, Enumerable.Category.Building);
            store.ProffesionCategory.Add(Enumerable.Proffesion.Sportsman, Enumerable.Category.Sport);
            store.ProffesionCategory.Add(Enumerable.Proffesion.Cook, Enumerable.Category.Cookery);
            store.GetRelevantProduct(products, workedPeople);
        }

        static void OutputResult()
        {
            foreach (var str in store.RelevantProduct)
            {
                Console.WriteLine("Customer Name: {0}; Product Name {1};", str.Key, str.Value);
            }
        }


    }
}
