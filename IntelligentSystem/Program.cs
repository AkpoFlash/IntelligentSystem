using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            IntelligentSystem.InitializeProduct();
            IntelligentSystem.InitializeWorkedPeople();

            Console.WriteLine("Products before discount for category:");
            IntelligentSystem.OutputProducts();

            IntelligentSystem.DiscountForCategories();

            Console.WriteLine("Products after discount for category:");
            IntelligentSystem.OutputProducts();

            IntelligentSystem.CalculateRelevantProducts();

            Console.WriteLine("Result products for customers:");
            IntelligentSystem.OutputResult();

            Console.ReadKey();
        }


    }
}
