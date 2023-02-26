namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = VehicleFactory.GetVehicle();
            vehicle.Drive();
        }
    }
}
