﻿using System;
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
        public decimal DiscountPercent { get; set; }


        public Product(int id, int count, string name, decimal cost, Enumerable.Category category, decimal discountPercent = 0)
        {
            this.Id = id;
            this.Name = name;
            this.Count = count;
            this.Cost = cost;
            this.Category = category;
            this.DiscountPercent = discountPercent;
        }

        public decimal GetFullCost()
        {
            return Math.Round(this.Cost - (this.Cost * this.DiscountPercent / 100), 2);
        }

        public override string ToString()
        {
            return String.Format("id: {0}; Name: {1}; Cost: {2}; Discount: {3}% Count: {4}; Category: {5}", this.Id, this.Name, this.Cost, this.DiscountPercent, this.Cost, this.Category.ToString());
        }


    }
}
