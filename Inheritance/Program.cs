using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE!
            // give this class 4 members that all Animals have in common


            // Create a class Bird DONE!
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile DONE!
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            Bird cardinal = new Bird("Cardinal", 5, 0, false, true, true, "Omnivore", 2 );

            Console.WriteLine($"My favorite bird is a {cardinal.Name}. It has {cardinal.Wings} wings, {cardinal.Legs} legs, and is {cardinal.Age} years old. This bird is an {cardinal.Type}.");
            Console.WriteLine("------------------------");
            Console.WriteLine("Current Status: Adopted, Warm Blooded, Has Feathers");
            Console.WriteLine($"{cardinal.IsAdopted}, {cardinal.IsWarmBlooded}, {cardinal.HasFeathers}");

            Console.WriteLine("------------------------");

            Reptile reptile = new Reptile("Turtle", 30, 4, true, true, true, "semi-aquatic", "withdraw");

            Console.WriteLine($"A cool reptile is a {reptile.Name}. It is {reptile.Age} years old and has {reptile.Legs} legs. This reptile's enviroment is {reptile.Environment} and it's defense is {reptile.Defense}.");
            Console.WriteLine("------------");
            Console.WriteLine("Current Status: Adopted, Cold Blooded, Has Scales");
            Console.WriteLine($"{reptile.IsAdopted}, {reptile.IsColdBlooded}, {reptile.HasScales}");


            /*Create an object of your Bird class DONE!
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class DONE!
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
