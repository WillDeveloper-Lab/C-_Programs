using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrescimentoPopulacionalV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da população A: ");
            double populacaoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual a taxa de Crescimento da População A: ");
            double taxaA = Convert.ToDouble(Console.ReadLine());
            taxaA = taxaA / 100;
            Console.Write("Digite o tamanho da população B: ");
            double populacaoB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual a taxa de Crescimento da População B: ");
            double taxaB = Convert.ToDouble(Console.ReadLine());
            taxaB = taxaB / 100;
            int anos = 0;
            if (populacaoA > populacaoB)
            {
                while (populacaoA >= populacaoB)
                {
                    Console.WriteLine("entrei A");
                    populacaoA += populacaoA * taxaA;
                    populacaoB += populacaoB * taxaB;
                    anos++;
                    Console.WriteLine($"Foram necessarios {anos} anos para que a população B chegasse a: {populacaoB}");
                }
            }
            else
            {
                while (populacaoB >= populacaoA)
                {
                    Console.WriteLine("entrei b");
                    populacaoA += populacaoA * taxaA;
                    populacaoB += populacaoB * taxaB;
                    anos++;
                    Console.WriteLine($"Foram necessarios {anos} anos para que a população A chegasse a: {populacaoA}");
                }
            }
            Console.ReadKey();
        }
    }
}
