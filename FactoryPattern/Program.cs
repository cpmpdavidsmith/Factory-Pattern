namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelNum;
            bool input = false;
            do
            {
            Console.WriteLine("Choose if you would like to have 2, 3, or 4 wheels on your vehicle:");
            input = int.TryParse(Console.ReadLine(), out wheelNum);
            } while (input == false);

            var vehicle = VehicleFactory.GetVeVehicle(wheelNum);
            vehicle.VehicleType();
        }
    }
}
