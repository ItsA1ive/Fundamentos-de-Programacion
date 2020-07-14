using System;
using System.Reflection.Metadata;

namespace Clase_2_ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos de entrada

            Console.Write("Escriba el lado w: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Escriba el lado t: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Escriba el angulo c: ");
            double c = double.Parse(Console.ReadLine());

            //Analisis de datos

            double cRad = c * Math.PI / 180;

            double e = Math.PI - cRad;

            double d = Math.Asin(t * Math.Sin(e) / w);

            double b = Math.PI - d - e;

            double x = t * Math.Sin(b) / Math.Sin(d);

            //Salida de datos

            Console.WriteLine("El lado x es: " + x);


        }
    }
}
