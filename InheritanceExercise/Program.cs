using System;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TwoWheeled biclicle = new TwoWheeled();

            biclicle.fuelType = "energy";
            biclicle.MaxSpeed = "69";
            biclicle.StatusTire = "punctured";
            biclicle.motor = true;

            
        }
    }
}
