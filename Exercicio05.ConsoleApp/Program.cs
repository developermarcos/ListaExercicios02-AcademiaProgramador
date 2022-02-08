using System;
//Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
//iguais deverá se somar os dois, caso contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//variável C e mostrar seu conteúdo na tela.

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Informe o primeiro numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            if(a == b)
            {
                c = a + b;
                Console.WriteLine("A soma de {0} e {1} é igual a {2}:", a.ToString(), b.ToString(), c.ToString());
            }
            else
            {
                c = a * b;
                Console.WriteLine("A multiplicação de {0} e {1} é igual a {2}:", a.ToString(), b.ToString(), c.ToString());
            }
            Console.ReadKey();
        }
    }
}
