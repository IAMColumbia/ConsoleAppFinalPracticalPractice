using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFinalPracticalPractice.Models
{

    public enum Flavor { Chocolate, Vanilla, Stawberry, RockRoad , MintChocolateChip, PeanutButter }

    public class Scoop : IProduct
    {
       
        public Flavor flavor;
        public double Price { get; set; }

        public string Name
        {
            get { return this.flavor.ToString(); }

        }

        public Scoop() : this(Flavor.Vanilla)
        {
            //Default scoop is Vanilla
        }

        public Scoop(Flavor f)
        {
            this.Price = .5;
            this.flavor = f;
        }

        public string About()
        {
            return $"{this.flavor}\t{this.Price:c}\n";
        }
    }
}
