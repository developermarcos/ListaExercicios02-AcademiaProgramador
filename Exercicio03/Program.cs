using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double abaixoPeso = 15.5;
            double[] faixaPesoNormal = { 15.5, 25 };
            double[] faixaAcimaPeso = { 25, 30 };
            const double obeso = 30;

            double altura, peso, imc;

            Console.WriteLine("Informe o seu peso em quilos: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a sua altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());
            imc = peso / (altura + altura);
            if(imc < abaixoPeso)
            {
                Console.WriteLine("Abaixo do peso");
            }else if (imc >= faixaAcimaPeso[0] && imc < faixaAcimaPeso[1])
            {
                Console.WriteLine("Peso normal");
            }else if (imc >= faixaAcimaPeso[0] && imc < faixaAcimaPeso[1])
            {
                Console.WriteLine("Acima do Peso");
            }else if(imc <= obeso)
            {
                Console.WriteLine("Você está obeso (a)");
            }
            Console.ReadKey();

        }
    }
}
//O IMC – Índice de Massa Corporal é um critério da Organização Mundial
//de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
//adulta
//• A fórmula é IMC = peso / (altura) ²
//• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
//sua condição de acordo com a tabela abaixo.
//IMC em adultos Condição
//Abaixo de 18,5 Abaixo do peso
//Entre 18,5 e 25 Peso normal
//Entre 25 e 30 Acima do peso
//Acima de 30 obeso

