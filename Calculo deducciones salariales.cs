using System;

namespace Calculo_de_deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
           // Datos de entrada

            Console.Write("Ingrese salario mensual: ");
            double S = double.Parse(Console.ReadLine());

            Console.Write("Tipo de contrato; 1 para dependiente o 2 para independiente: ");
            double TC = double.Parse(Console.ReadLine());

            double bC = S * 0.4;

            if (bC < 877803)
            {
                bC = 877803;
            }

            //Datos Independiente
            if (TC == 2)
            {
                Console.Write("Ingrese numero equivalente a clase de riesgo laboral: ");
                double C = double.Parse(Console.ReadLine());

                if (C == 1)
                {
                    C = 0.00522;
                }

                if (C == 2)
                {
                    C = 0.01044;
                }

                if(C == 3)
                {
                    C = 0.02436;
                }

                if (C == 4)
                {
                    C = 0.04350;
                }

                if (C == 5)
                {
                    C = 0.06960;
                }



                // Deducciones para Independiente
                                
                double P = bC * 0.16;

                double EPS = bC * 0.125;

                double ARL = bC * C;

                // Datos de salida Independiente

                double SR = S - P - EPS - ARL;

                double SA = SR * 12;

                Console.WriteLine("Salario real mensual: " + SR);
                Console.WriteLine("Salario anual: " + SA);
                

            }

            // Deducciones para Dependiente

            double P2 = bC * 0.04;

            double EPS2 = bC * 0.04;

            double SR2 = S - P2 - EPS2;

            double SA2 = SR2 * 12 + S;

            Console.WriteLine("Salario real mensual: " + SR2);
            Console.WriteLine("Salario anual: " + SA2);

        }
    }
}
