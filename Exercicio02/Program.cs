using System;
//Escreva um algoritmo que leia três valores inteiros e diferentes e
//mostre-os em ordem decrescente.
namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];
            int ordena = 0;

            Console.WriteLine("A seguir informa 3 valores para que o sistema ordene de forma decrescente");

            for (int i = 0; i < valores.Length; i++)
            {
                int numero = i + 1;
                Console.Write("\nInforma o {0}º numero: ", numero.ToString());
                valores[i] = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Numero {0}", valores[i].ToString());
            }
            for (int i = 0; i < valores.Length; i++)
            {
                for (int y = 0; y < valores.Length - 1; y++)
                {
                    if (valores[y] > valores[y+1])
                    {
                        ordena = valores[y+1];
                        valores[y+1] = valores[y];
                        valores[y] = ordena;
                    }
                }
            }

            Console.WriteLine("\nSequencia ordenada");
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("\n {0}", valores[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
