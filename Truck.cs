public class Truck : IAutomobile
{
    // Implement the properties from IAutomobile
    public double Speed { get; private set; }
    public int Wheels { get; private set; }
    public string LicensePlate { get; private set; }
    public double Weight { get; private set; }

    // Constructor that takes three parameters
    public Truck(double speed, double weight, string licenseNum)
    {
        Speed = speed;
        Weight = weight;
        LicensePlate = licenseNum;

        // Determine the number of wheels based on the weight
        if (Weight < 400)
        {
            Wheels = 8;
        }
        else
        {
            Wheels = 12;
        }
    }

    // Public method to describe the Truck
    public void Stringify()
    {
        Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
    }

    // Method to increase the speed of the Truck by 5
    public void SpeedUp()
    {
        Speed += 5;
    }

    // Method to decrease the speed of the Truck by 5
    public void SlowDown()
    {
        Speed -= 5;
    }
}
