using System;

namespace Inheritance;

public class Animal
{
    
    
    //properties for an animal
    
    public string AnimalType { get; set; }
    public bool IsAlive { get; set; }
    public int Age { get; set; }
    public int LegCount { get; set; }
    public string LandSeaAir { get; set; }

    public void AnimalProperties()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"The Type of animal is: {AnimalType}: ");
        Console.WriteLine($"It is {IsAlive} that the animal is alive");
        Console.WriteLine($"The animal is {Age} and the leg count is {LegCount}");
        Console.WriteLine($"The animal belongs in a {LandSeaAir}");
        Console.WriteLine("-------------------------------");
    }
    
    

}