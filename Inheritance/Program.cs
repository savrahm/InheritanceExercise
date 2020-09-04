using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird parrot = new Bird();
            parrot.Legs = 2;
            parrot.Age = 85;
            parrot.Sound = "SQUAWK!";
            parrot.Diet = "birdseed, remote control buttons, and human fingers";
            parrot.Name = "James Van Der Beak";
            parrot.Species = "Blue Macaw";
            parrot.CanFly = true;
            parrot.CanTalk = true;

            parrot.LegalAd();
            Console.WriteLine();
            parrot.FunFacts();
            Console.WriteLine();
            string lunch = "sandwich";
            parrot.Steal(lunch);
            parrot.Whistle();



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile garterSnake = new Reptile();
            garterSnake.Legs = 0;
            garterSnake.Age = 1;
            garterSnake.Sound = "Sssss";
            garterSnake.Diet = "bugs, frogs, and stuff";
            garterSnake.Name = "Slithourney Weaver";
            garterSnake.Species = "Red-Sided Garter Snake";
            garterSnake.IsColdBlooded = true;
            garterSnake.DefenseMechanism = "play dead x.x";

            //garterSnake.LegalAd();
            //Console.WriteLine();
            //garterSnake.FunFacts();
            //Console.WriteLine();
            //garterSnake.TinyHat();
            //garterSnake.OpenToOpportunities();

        }
    }
}
