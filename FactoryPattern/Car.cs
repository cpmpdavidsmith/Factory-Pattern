using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
		public Car()
		{
		}

        public void VehicleType()
        {
            Console.WriteLine($"Four wheels gives you the most options with a coupe, sedan, SUV or even a truck:");
            
        }
    }
}

