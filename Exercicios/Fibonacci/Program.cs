using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int anterior = 0;
            int atual = 1;
            int soma = 0;
            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(anterior);
            Console.WriteLine(atual);
            for (int i = 2; i < num; i++)
            {
                soma = anterior + atual;
                Console.WriteLine(soma);
                anterior = atual;
                atual = soma;
            }

            Console.ReadKey();
        }
    }
}
