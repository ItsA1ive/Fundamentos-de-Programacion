using System;

namespace Calculo_de_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su peso en Kg: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double a = double.Parse(Console.ReadLine());

            double imc = (p /(a * a));

            if (imc < 18.4)
            {
                Console.WriteLine("Usted esta BAJO DE PESO ya que su IMC es: " + imc);
            }

            else if ( 18.5 <= imc && imc <= 24.9 )
            {
                Console.WriteLine("Usted tiene PESO NORMAL ya que su IMC es: " + imc);
            }

            else if (25 <= imc && imc <= 29.9)
            {
                Console.WriteLine("Usted tiene SOBREPESO ya que su IMC es: " + imc);
            }

            else if (imc >= 30)
            {
                Console.WriteLine("Usted tiene OBESIDAD ya que su IMC es: " + imc);
            }

        }
    }
}
