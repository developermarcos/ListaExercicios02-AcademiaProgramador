using System;
//Faça um algoritmo para receber um número qualquer e informar na tela se
//é par ou ímpar
namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Informa um numero");
            numero = Convert.ToDouble(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine("É par");
            }
            else
            {
                Console.WriteLine("É impar");
            }
            Console.ReadKey();
        }
    }
}
