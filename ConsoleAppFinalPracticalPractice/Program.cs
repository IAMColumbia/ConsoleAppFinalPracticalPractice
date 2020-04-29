using ConsoleAppFinalPracticalPractice.Models;
using System;

namespace ConsoleAppFinalPracticalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===scOOPs IceCream===");

            IceCreamSugarCone cone1 = new IceCreamSugarCone();
            cone1.AddScoop(new Scoop(Flavor.Vanilla));
            cone1.AddTopping(new Sprinkles());
            Console.WriteLine(cone1.About());

            IceCreamWaffleCone cone2 = new IceCreamWaffleCone();
            cone2.AddScoop(new Scoop(Flavor.MintChocolateChip));
            cone2.AddScoop(new Scoop(Flavor.MintChocolateChip));
            cone2.AddTopping(new WhippedCream());
            Console.WriteLine(cone2.About());

            IceCreamSundae sundae1 = new IceCreamSundae();
            sundae1.Scoops.Add(new Scoop(Flavor.PeanutButter));
            sundae1.Toppings.Add(new Sprinkles());
            sundae1.Toppings.Add(new WhippedCream());
            sundae1.Toppings.Add(new Cherry());
            Console.WriteLine(sundae1.About());

            Scoop s = new Scoop();
            //Console.WriteLine(s.About());
            Scoop rr = new Scoop(Flavor.RockRoad);
            //Console.WriteLine(rr.About());

            Console.ReadKey();
        }
    }
}
