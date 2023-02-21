using System;
namespace FactoryPattern
{
	public class TrikeMotorcycle : IVehicle
	{
		public TrikeMotorcycle()
		{
		}

        public void VehicleType()
        {
            Console.WriteLine($"this Trike is in drive");
        }
    }
}

