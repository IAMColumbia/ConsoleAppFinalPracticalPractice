using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFinalPracticalPractice.Models
{
    public abstract class Icecream
    {
        public double Price { get; set; }

        //Scoop
        public List<Scoop> Scoops;
        public List<Topping> Toppings;

        public Icecream()
        {
            this.Price = 0.5; //50 cents US
            this.Scoops = new List<Scoop>();
            this.Toppings = new List<Topping>();
        }

        public Double GetPrice()
        {

            double totalPrice = this.Price;
            //TODO deal with topping
            foreach (var t in this.Toppings)
            {
                totalPrice += t.Price;
            }
            //TODO deal with scoops
            foreach (var s in this.Scoops)
            {
                totalPrice += s.Price;
            }
            
            return totalPrice;
        }

        public void AddScoop(Scoop s)
        {
            this.Scoops.Add(s);
        }

        public void AddTopping(Topping t)
        {
            this.Toppings.Add(t);
        }

        public string GetScoopText()
        {
            string strScoop = String.Empty;
            foreach (Scoop s in this.Scoops)
            {
                strScoop += s.About();
            }
            return strScoop;
        }


        public string GetToppingText()
        {
            string strtop = String.Empty;
            foreach (Topping t in this.Toppings)
            {
                strtop += t.About();
            }
            return strtop;
        }

        public string About()
        {
            string strAbout = "IceCream Order\n";
            strAbout += "Item\t\tPrice\n";
            strAbout += $"{this.ToString().Replace("ConsoleAppFinalPracticalPractice.Models.IceCream","")}\t{this.Price:c}\n";
            //TODO Scoop Text
            strAbout += GetScoopText();
            //PeanutButter    $0.50

            //TODO Topping
            strAbout += this.GetToppingText();
            strAbout += "--------------------\n";

            strAbout += $"total\t{this.GetPrice():c}\n";
            return strAbout;
        }
    }
}
