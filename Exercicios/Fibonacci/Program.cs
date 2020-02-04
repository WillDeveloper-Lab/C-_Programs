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
            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int anterior = 0;
            int atual = 1;
            Console.Write(anterior);
            Console.Write(atual);
            for (int i = 2; 2<=num; i++)
            {
                anterior = atual;
                atual += anterior;
                Console.WriteLine(atual);
            }
            Console.ReadKey();
        }
    }
}
