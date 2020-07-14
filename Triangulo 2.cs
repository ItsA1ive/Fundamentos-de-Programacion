using System;

namespace Triangulo_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double t = 3.61;
            double a = 33.69;

            double aRadianes = a * Math.PI / 180;

            double y = t * Math.Sin(aRadianes);
            double z = t * Math.Cos(aRadianes);
            double c = Math.Atan(z / y);

            double cGrados = c * 180 / Math.PI;

            Console.WriteLine("El lado y mide: " + y);
            Console.WriteLine("El lado z mide: " + z);
            Console.WriteLine("El angulo c mide: " + cGrados);
        }
    }
}
