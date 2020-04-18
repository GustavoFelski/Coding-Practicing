using System;

namespace OverloadMetodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x, y, z;
            a = 10;
            b = 7;
            c = 3;
            Console.WriteLine($"{a} + {b} = {Soma(a,b)}");
            Console.WriteLine($"{a} + {b} + {c} = {Soma(a, b,c)}\n");
            x = 2.2;
            y = 4.3;
            z = 8.1;
            Console.WriteLine($"{x} + {y} = {Soma(x, y)}");
            Console.WriteLine($"{y} + {x} + {z} = {Soma(y, x, z)}");


        }

        static double Soma(double h, double j){
            return h + j;
        }
        static double Soma(double h, double j, double k)
        {
            return h + j + k;
        }
    }
}
