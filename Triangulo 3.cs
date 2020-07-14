using System;

namespace Triangulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 56.61;
            double z = 3;

            double cRadianes = c * Math.PI / 180;

            double y = z / Math.Tan(cRadianes);
            double t = Math.Sqrt(y * y + z * z);
            double a = Math.Atan(y / z);

            double aGrados = a * 180 / Math.PI;

            Console.WriteLine("El lado y es: " + y);
            Console.WriteLine("El lado t es: " + t);
            Console.WriteLine("El angulo a es: " + aGrados);

        }
    }
}
