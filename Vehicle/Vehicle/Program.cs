using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            FourWheeledVehicles BMWX4 = new FourWheeledVehicles();
            TwoWheeledVehicles Kawasaki = new TwoWheeledVehicles();
            FourWheeledVehicles FerrariEnzo = new FourWheeledVehicles();
            AirVehicles boeing747 = new AirVehicles();
        }
    }

    class vehicle
    {
        string color;
        string manufacture;
        float maximoSpead;
        int carriageCapacity;
        String fuelType;

        public void Start() { }
        public void StopVehicle() { }
        public void Drive() { }
        public void Refuel() { }
        public void RunAtMaxSpeed() { }
        public void TransportPeople() { }

    }

    class WheeledVehicles : vehicle { }
    class NonWheeledVehicles : vehicle { }
    class FourWheeledVehicles : WheeledVehicles { }
    class TwoWheeledVehicles : WheeledVehicles { }
    class SeaVehicles : NonWheeledVehicles { }
    class AirVehicles : NonWheeledVehicles { }
}
