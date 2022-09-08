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
            Mercedes mercedes = new Mercedes();
            mercedes.DisplayInfo();
        }
    }

    class Car
    {
        private decimal price;
        public string color;
        protected int maxSpeed;
        public decimal Price { get; set; }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }
        public virtual void DisplayInfo()
        {
            price = 10000;
            color = "black";
            maxSpeed = 300;

            Console.WriteLine("Price is:" + price);
            Console.WriteLine("Color is:" + color);
            Console.WriteLine("maximo Speed is:"+ maxSpeed);
        }
    }
    class Mercedes : Car
    {
        public override void DisplayInfo()
        {
            base.Price = 15000;
            base.color = "blue";
            base.maxSpeed = 280;

            Console.WriteLine("Price is:" + Price);
            Console.WriteLine("Color is:" + color);
            Console.WriteLine("maximo Speed is:" + maxSpeed);
        }

    }
}