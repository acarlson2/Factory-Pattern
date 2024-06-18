namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you want on your vehicle?");
            int numWheels = int.Parse(Console.ReadLine());

            IVehicle newVehicle = VehicleFactory.GetVehicle(numWheels);

            newVehicle.Drive();
        }
    }
}
