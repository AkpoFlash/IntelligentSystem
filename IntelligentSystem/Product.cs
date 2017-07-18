using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Cost { get; set; }
        public Enumerable.Category Category { get; set; }


        public Product(int id, int count, string name, decimal cost, Enumerable.Category category)
        {
            this.Id = id;
            this.Name = name;
            this.Count = count;
            this.Cost = cost;
            this.Category = category;
        }

        public override string ToString()
        {
            return String.Format("id: {0}; Name: {1}; Cost: {2}; Category: {3}", this.Id, this.Name, this.Cost, this.Category.ToString());
        }


    }
}
