using System;

namespace Clase_2_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos de entrada

            Console.Write("Escriba el angulo d: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Escriba el angulo b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Escriba el lado y: ");
            double y = double.Parse(Console.ReadLine());

            //Analisis de datos

            double dRad = d * Math.PI / 180;

            double bRad = b * Math.PI / 180;

            double eRad = Math.PI / 2 - dRad - bRad;

            double cRad = Math.PI / 2 - eRad;

            double z = Math.Tan(cRad) * y;

            Console.WriteLine("El lado z es: " + z);

        }
    }
}
