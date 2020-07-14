using System;
using System.Reflection.Metadata;

namespace Clase_2_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de entrada

            Console.Write("Escriba el lado w: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Escriba el angulo d: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Escriba el lado x: ");
            double x = double.Parse(Console.ReadLine());

            // Analisis de datos

            double dRad = d * Math.PI / 180;

            double z = w * Math.Sin(dRad) / Math.Sin(Math.PI / 2);

            double xmasy = Math.Sqrt(w * w - z * z);

            double y = xmasy - x;

            // Salida de datos

            Console.WriteLine("El lado y es: " + y);

        }
    }
}
