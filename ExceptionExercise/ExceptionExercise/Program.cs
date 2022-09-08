using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            double x = 0 , y= 0;
            Console.WriteLine("entre o primeiro numero: ");
            try
            {
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("entre o primeiro numero: ");
                y = double.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Resultado: " + calc.Div(x, y).ToString());


        }
    }
    interface Icalc
    {
        double Div(double x, double y);
        double Soma(double x, double y);
        double Sub(double x, double y);
        double Mult (double x, double y);

    }

    class Calc : Icalc
    {
        private double result;
        public double Div(double x, double y)
        {
            // double res = 0;
            try
            {
                double res = x / y;
                return result = res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return result = 0;
            }
        }

        public double Mult(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Soma(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Sub(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Result
        {
            get { return result; }
        }
    }
}

