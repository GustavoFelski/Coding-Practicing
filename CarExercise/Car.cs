using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    class Car
    {
        private decimal price;
        public string color;
        protected int MaxSpeed;
        protected decimal priced
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void DisplayInfo() 
        {
            price = 1000;
            MaxSpeed = 300;
            color = "black";
            Console.WriteLine($"Defaut values is:\n price {price}\n color {color}\n max speed {MaxSpeed}");
        }
    }
}
