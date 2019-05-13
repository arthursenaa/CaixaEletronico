using System;

namespace CaixaEletronicoCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {100, 50, 20, 10, 5, 2, 1};

            Console.Write("Digite o valor do seu saque: ");
            int saque = int.Parse(Console.ReadLine());

            for (int i = 0; i < notas.Length; i++)
            {
                int qntdeNotas = saque / notas[i];
                saque = saque%notas[i];
                if(qntdeNotas !=0)
                {
                    Console.WriteLine($"Você recebeu {qntdeNotas} nota(s) de {notas[i]}");
                }
            }
        }
    }
}
