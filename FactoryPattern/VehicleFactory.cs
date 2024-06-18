public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numWheels)
    {
        IVehicle retVal;

        if(numWheels == 4)
        {
            retVal = new Car();
        }
        else
        {
            retVal = new Motorcycle();
        }

        return (IVehicle)retVal;
    }
}