using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFinalPracticalPractice.Models
{
    public abstract class Topping : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Topping()
        {
            this.Price = 0;
            this.Name = "Cherry";
        }

        public string About()
        {
            return $"{this.Name}\t{this.Price:c}\n";
        }
    }
}
