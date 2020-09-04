using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public int Legs { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }
        public string Diet { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public Animal(int legs, int age, string sound, string diet, string name, string species)
        {
            Legs = legs;
            Age = age;
            Sound = sound;
            Diet = diet;
            Name = name;
            Species = species;
        }
        public Animal()
        {

        }

        public void LegalAd()
        {
            Console.WriteLine($" Here at Wilder, Clawson, And McGrowl Law Firm, our legal eagles will fight tooth and nail for you.");
                Console.WriteLine();
            Console.WriteLine($" Currently accepting new clients is {Name} the {Species}. \n Join {Name} for a quick snack " +
            $"of {Diet} and you \n might just hear his famous catchphrase--{Sound}!!--which has been appreciated \n by many a discerning " +
            $"client over the course of his distinguished, {Age}-year career.");
            Console.WriteLine();
            Console.WriteLine($" Crawl, climb, or fly over and talk with {Name} today!");
        }

        public void FunFacts()
        {
            Console.WriteLine($" More fun facts about {Name}:");
        }
    }
}
