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
            
            var myBird = new Bird();
            myBird.WingColor = "green";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.WingLength = 10;
            
            myBird.Wing();
            myBird.Fly();
            
            
            
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var myReptile = new Reptile()
            {
                IsColdBlooded = true,
                IsFrozen = true,
                Habitat = "swamp",
                CanGrow = true
                
            };

            myReptile.BodyTemperature();
            myReptile.Conditions();
            
            //Animal class
            

            var myAnimal = new Animal()
            {
                AnimalType = "Zebra",
                IsAlive = true,
                Age = 10,
                LegCount = 4,
                LandSeaAir = "land"

            };
            
            myAnimal.AnimalProperties();

            

        }
    }
}
