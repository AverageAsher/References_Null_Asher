public class Sedan : IAutomobile
{
    // Implement the properties from IAutomobile
    public double Speed { get; private set; }
    public int Wheels { get; private set; }
    public string LicensePlate { get; private set; }

    // Constructor that takes a double parameter for speed
    public Sedan(double speed)
    {
        Speed = speed;
        Wheels = 4;
        LicensePlate = "GCTC-06";
    }

    // Public method to describe the Sedan
    public void Stringify()
    {
        Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
    }

    // Method to increase the speed of the Sedan by 5
    public void SpeedUp()
    {
        Speed += 5;
    }

    // Method to decrease the speed of the Sedan by 5
    public void SlowDown()
    {
        Speed -= 5;
    }
}
