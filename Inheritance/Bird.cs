using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanFly = true;
        public bool CanTalk { get; set; }

        public void Steal(string loot)
        {
            Console.WriteLine($" {Name} has swooped down and stolen your {loot} :(");
        }

        public void Whistle()
        {
            Console.WriteLine($" {Name} has been whistling the same 5 seconds of the Star Wars theme for the last 6 hours!");
        }
    }
}
