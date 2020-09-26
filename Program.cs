using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           double milhas;
           double kms = 1.609;

            Console.Write("digite uma medida em milha(s): ");
            milhas = double.Parse(Console.ReadLine());

            double resultado = milhas*kms;

            Console.WriteLine($"o valor de milhas para quilometros É de..: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear(); 
        }
    }
}