using System;

namespace _21_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int sumaCartas = carta1 + carta2;
            int siguienteCarta = 0;
            int total = sumaCartas;

            Console.WriteLine("Carta 1: " + carta1);
            Console.WriteLine("Carta 2: " + carta2);
            Console.WriteLine("Total : " + total);
            Console.WriteLine("Continuar: s/n");
            string continuar = Console.ReadLine();

            while (continuar == "s" && total <= 21)
            {
                siguienteCarta = aleatorio.Next(1, 11);
                total += siguienteCarta;
                Console.WriteLine("Nueva carta: " + siguienteCarta);

                if (total < 21)
                {
                    Console.WriteLine("Total : " + total);
                    Console.WriteLine("Continuar: s/n");
                    continuar = Console.ReadLine();
                }
                if (total == 21)
                {
                    Console.WriteLine("Gano!! :D");
                    continuar = "n";
                }
                if (total > 21)
                {
                    Console.WriteLine("Perdio :c");
                    Console.WriteLine("Total : " + total);
                    continuar = "n";
                }
            }

        }
    }
}
