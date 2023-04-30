using System;
using System.ComponentModel.Design;

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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.Flies = true;
            myBird.FeatherColor = "Black";
            myBird.NoseBeak = true;
            myBird.NumberOfLegs = 4;
            Console.WriteLine($"Wow! they have all {myBird.NumberOfLegs} legs I didn't know that. With {myBird.FeatherColor} wings?");
            if (myBird.Flies)
            {
                Console.WriteLine($"FLY! fly!!");
            }
            else
            {
                Console.WriteLine($"dead");
            }
            var myReptile = new Reptile();
            myReptile.NeedsFood = false;
            myReptile.Lives = "Dessert";
            myReptile.IsSlimy = true;
            myReptile.FavDrink = "water";
            Console.WriteLine($"So these reptiles live in the {myReptile.Lives}? Do they drink a lot of {myReptile.FavDrink}");
            if(myReptile.NeedsFood)
            {
                Console.WriteLine($"I am so hungry");
            }
            else
            {
                Console.WriteLine($"I am so full");
            }
        
        
        }
    }
}
