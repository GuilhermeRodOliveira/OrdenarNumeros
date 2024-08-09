using System;

namespace EXERCICIOS_ESTRUTURA_CONDICIONAIS_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Crie um programa que peça ao usuário para inserir três números e, em seguida, imprima o maior e o menor número.
            Console.WriteLine("Vou ordenar os números em ordem decresente.");
            Console.WriteLine("Insira o primeiro numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número:");
            int numero3 = int.Parse(Console.ReadLine());

            int maiorNumero = Math.Max(numero1, Math.Max(numero2,numero3));

            Console.WriteLine($"O maior número é {maiorNumero}");
        }
    }
}
