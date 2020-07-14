using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            
            Console.WriteLine("Ingrese los digitos binarios uno por uno");

            Console.Write("Primer digito binario: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Segundo digito binario: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Tercer digito binario: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Cuarto digito binario: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Quinto digito binario: ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Sexto digito binario: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Septimo digito binario: ");
            int g = int.Parse(Console.ReadLine());

            // Calculo de datos ingresados

            double a2 = Math.Pow(a * 2, 6);

            double b2 = Math.Pow(b * 2, 5);

            double c2 = Math.Pow(c * 2, 4);

            double d2 = Math.Pow(d * 2, 3);

            double e2 = Math.Pow(e * 2, 2);

            double f2 = Math.Pow(f * 2, 1);

            double g2 = Math.Pow(g * 2, 0);

            // Resultado

            double nEntero = a2 + b2 + c2 + d2 + e2 + f2 + g2;

            Console.WriteLine("El digito binario a numero entero es: " + nEntero);

        }
    }
}
