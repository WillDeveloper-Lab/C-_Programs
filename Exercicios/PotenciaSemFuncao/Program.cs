using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotenciaSemFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int calcula = a;
            for(int i = 1; i <= b; i++)
            {
                calcula *= a;
                Console.WriteLine(calcula);
            }
            Console.ReadKey();
        }
    }
}
