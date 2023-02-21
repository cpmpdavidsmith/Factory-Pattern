using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

        public void VehicleType()
        {
            Console.WriteLine($"Two wheels are exciting!!! with your choice of chopper, dirt bike or sport motorcycle.");
            
        }
    }
}

