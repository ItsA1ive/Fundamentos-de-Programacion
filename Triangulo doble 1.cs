using System;

namespace Clase_2_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos iniciales
            Console.Write("Ingrese el angulo b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado y: ");
            double y = double.Parse(Console.ReadLine());

            //Analizando datos
            double bRad = b * Math.PI / 180;

            double t = Math.Sqrt(z * z + y * y);

            double a = Math.Atan(y / z);

            double d = Math.PI - (bRad + a) - (Math.PI / 2);

            double x = t * Math.Sin(bRad) / Math.Sin(d);

            //Salida de datos
            Console.WriteLine("El lado x es igual a: " + x);

        }
    }
}
