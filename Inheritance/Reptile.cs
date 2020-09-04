using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public bool IsColdBlooded = true;
        public string DefenseMechanism { get; set; }

        public void TinyHat()
        {
            Console.WriteLine($" {Name} has sometimes been known to wear a tiny, charming hat!");
        }

        public void OpenToOpportunities()
        {
            Console.WriteLine($" {Name} is also available for Halloween parties. Serious inquiries only.");
        }
    }
}
