using System;

namespace Desafio1
{
    class Program
    {
        static void Main()
        {
            string entrada = Console.ReadLine();

            string[] divisao = entrada.Split(' ');
            
            double horas = Convert.ToDouble(divisao[0]);
            double quilometragem = Convert.ToDouble(divisao[1]);
            
            double total = horas * quilometragem / 12;
            Math.Round(total, 3);

            Console.WriteLine(total.ToString("0.000"));
        }
    }
}
