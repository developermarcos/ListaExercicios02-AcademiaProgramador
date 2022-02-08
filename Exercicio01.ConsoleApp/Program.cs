using System;
//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
//soma de A + B é menor que C.
namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = Convert.ToDecimal(Console.ReadLine());

            if ((a+b) < c)
            {
                Console.Write("A soma de {0} e {1} é menor que {2}", a.ToString(), b.ToString(), c.ToString());
            }
            else
            {
                Console.Write("A soma de {0} e {1} é maior ou igual a {2}", a.ToString(), b.ToString(), c.ToString());
            }
            Console.ReadKey();
        }
    }
}
