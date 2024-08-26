using System;

namespace Inheritance;

public class Bird : Animal
{
    
    public string WingColor { get; set; }
    public bool CanFly { get; set; }
    public bool DoMigrate { get; set; }
    public int WingLength { get; set; }


    public void Wing()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"The wing color of a bird is: {WingColor}");
        Console.WriteLine($"The wing length of a bird is: {WingLength} inches");
        Console.WriteLine("-------------------------------");
        
        
    }

    public void Fly()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"It is {CanFly} that the bird can fly");
        Console.WriteLine($"It is {DoMigrate} that the bird can migrate");
        Console.WriteLine("-------------------------------");
    }
    
}
