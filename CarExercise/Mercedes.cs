using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    class Mercedes : Car
    {

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            base.color = "blue";
            base.MaxSpeed = 200;
            base.priced = 15000;
            
            Console.WriteLine($"Override values is:\n price {priced}\n color {color}\n max speed {MaxSpeed}");
        }

    }
}
