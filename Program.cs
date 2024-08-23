using System;

public interface IAutomobile
{
    double Speed { get; }
    int Wheels { get; }
    string LicensePlate { get; }
    void Stringify();
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Sedan object
        Sedan sedan1 = new Sedan(60);

        // Declare an IAutomobile object and assign it to the Sedan object
        IAutomobile auto1 = sedan1;

        // Create another new Sedan object with the same speed as the first
        Sedan sedan2 = new Sedan(60);

        // Call SpeedUp on the first Sedan object
        sedan1.SpeedUp();

        // Print the Speed of the sedan and the IAutomobile object
        Console.WriteLine($"Sedan1 Speed: {sedan1.Speed}");
        Console.WriteLine($"IAutomobile Speed: {auto1.Speed}"); // Same reference, same value

        // Compare the two objects (IAutomobile and first Sedan) and print the result
        Console.WriteLine($"Are sedan1 and auto1 the same reference? {ReferenceEquals(sedan1, auto1)}");

        // Call SpeedUp on the second Sedan object
        sedan2.SpeedUp();

        // Compare the two Sedan objects and print the result
        Console.WriteLine($"Are sedan1 and sedan2 the same reference? {ReferenceEquals(sedan1, sedan2)}");

        // Create a Truck object
        Truck truck = new Truck(45, 500, "TRK-12");

        // Create an array of IAutomobile and add all objects
        IAutomobile[] vehicles = { sedan1, sedan2, truck, auto1 };

        // Call the Stringify method on all objects using a foreach loop
        foreach (IAutomobile vehicle in vehicles)
        {
            vehicle.Stringify();
        }
    }
}
