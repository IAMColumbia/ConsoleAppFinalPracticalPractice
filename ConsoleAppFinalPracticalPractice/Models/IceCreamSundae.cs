using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFinalPracticalPractice.Models
{
    public class IceCreamSundae : Icecream
    {
        public IceCreamSundae()
        {
            //already set base price in icecream
            this.Price += .0;
        }
    }
}