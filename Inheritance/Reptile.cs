using System;

namespace Inheritance;

public class Reptile : Animal
{
    public bool IsColdBlooded { get; set; }
    public bool IsFrozen { get; set; }
    public string Habitat { get; set; }
    public bool CanGrow { get; set; }
    
    
    public void BodyTemperature()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"It is {IsColdBlooded} that the aligator is cold.");
        Console.WriteLine($"It is {IsFrozen} that the aligator is frozen.");
        Console.WriteLine("-------------------------------");
    }

    public void Conditions()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"The aligator belongs in a {Habitat}");
        Console.WriteLine($"It is {CanGrow} that the aligator is grown.");
        Console.WriteLine("-------------------------------");
        
        
    }
    
    
}


