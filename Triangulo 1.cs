using System;
using System.Security.Cryptography.X509Certificates;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 3;
            double y = 2;

            double a = Math.Atan(y / z);
            double c = Math.Atan(z / y);
            double t = Math.Sqrt(y * y + z * z);

            double aGrados = a * 180 / Math.PI;
            double cGrados = c * 180 / Math.PI;

            Console.WriteLine("Valor de a: = " + aGrados);
            Console.WriteLine("Valor de c: = " + cGrados);
            Console.WriteLine("Valor de t: = " + t);

        }
    }
}
