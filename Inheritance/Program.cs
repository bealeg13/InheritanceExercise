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

            Bird ostrich = new Bird();
            ostrich.CanTalk = false;
            ostrich.Diet = "plants";
            ostrich.HasFur = false;
            ostrich.CanFly = false;
            ostrich.Legs = 2;
            ostrich.Type = "Bird";

            ostrich.ShowBirdQualities();
            Console.WriteLine("_______________________");

            Reptile alligator = new Reptile();
            alligator.Legs = 4;
            alligator.Habitat = "swamplands";
            alligator.HasScales = true;
            alligator.HasTail = true;
            alligator.Diet = "fish";
            alligator.Type = "Reptile";

            alligator.ShowReptileQualities();
            //Animal[] array = new Animal[2];
            //array[0] = alligator;
            //array[1] = ostrich;

            //foreach (var animal in array)
            //{
            //    Console.WriteLine($"Animal type: {animal.Type}");
            //    Console.WriteLine($"Amount of legs: {animal.Legs}");
            //    Console.WriteLine($"Animal diet: {animal.Diet}");
            //    Console.WriteLine($"Does the animal have fur: {animal.HasFur}");
            //    Console.WriteLine();
            //    Console.WriteLine();
        }


        /*Create an object of your Bird class
         *  give values to your members using the object of your Bird class
         *  
         * Creatively display the class member values 
         */

        /*Create an object of your Reptile class
         *  give values to your members using the object of your Reptile class
         *  
         * Creatively display the class member values 
         */
    }
}

